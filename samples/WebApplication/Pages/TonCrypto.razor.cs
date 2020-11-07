using System.Text.Json;
using System.Threading.Tasks;
using Blazored.Toast.Services;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Modules.Crypto;
using ch1seL.WebApplication.Utils;
using Microsoft.AspNetCore.Components;

namespace ch1seL.WebApplication.Pages
{
    public partial class TonCrypto
    {
        [Inject] private ITonClient TonClient { get; set; }
        [Inject] private IToastService ToastService { get; set; }

        private string MnemonicWords { get; set; }
        private string FactorizeResult { get; set; }
        private string RandomGenerateBytes { get; set; }
        private string Ed25519Keypair { get; set; }
        private string PublicKeyToStringResult { get; set; }
        private string Sha512Result { get; set; }
        private string Sha256Result { get; set; }
        private string ScryptSalt { get; set; }
        private string ScryptPassword { get; set; }
        private string ScryptResult { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await UpdateAll();
        }

        private async Task UpdateAll()
        {
            await Task.WhenAll(
                UpdateRandomGenerateBytes(),
                UpdateMnemonicWordsFromRandom(),
                UpdateEd25519KeypairRequest());
        }

        private async Task UpdateRandomGenerateBytes()
        {
            RandomGenerateBytes = "updating...";
            RandomGenerateBytes = await TonClient.Crypto.RandomGenerateBytes(20).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            StateHasChanged();
        }

        private async Task Factorize(ChangeEventArgs e)
        {
            FactorizeResult = "updating...";
            FactorizeResult =
                JsonSerializer.Serialize(await TonClient.Crypto.Factorize((string) e.Value).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message)));
            StateHasChanged();
        }

        private async Task PublicKeyToString(ChangeEventArgs e)
        {
            PublicKeyToStringResult = "updating...";
            PublicKeyToStringResult =
                await TonClient.Crypto.PublicKeyToString((string) e.Value).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            StateHasChanged();
        }

        private async Task Sha512(ChangeEventArgs e)
        {
            Sha512Result = "updating...";
            Sha512Result = await TonClient.Crypto.Sha512((string) e.Value).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            StateHasChanged();
        }

        private async Task Sha256(ChangeEventArgs e)
        {
            Sha256Result = "updating...";
            Sha256Result = await TonClient.Crypto.Sha256((string) e.Value).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            StateHasChanged();
        }

        private async Task UpdateMnemonicWordsFromRandom()
        {
            MnemonicWords = "updating...";
            MnemonicWords = await TonClient.Crypto.MnemonicWordsFromRandom(new TonMnemonicFromRandomParams())
                .CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            StateHasChanged();
        }

        private async Task UpdateEd25519KeypairRequest()
        {
            Ed25519Keypair = "updating...";
            Ed25519Keypair = JsonSerializer.Serialize(await TonClient.Crypto.Ed25519Keypair().CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message)));
            StateHasChanged();
        }


        private async Task Scrypt()
        {
            if (ScryptPassword == null || ScryptSalt == null) return;

            ScryptResult = "updating...";
            ScryptResult = await TonClient.Crypto.Scrypt(ScryptPassword, ScryptSalt);
            StateHasChanged();
        }
    }
}