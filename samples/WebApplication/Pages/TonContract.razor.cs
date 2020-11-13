using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.Toast.Services;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Modules.Contract;
using ch1seL.TonClientBlazor.Modules.Crypto;
using ch1seL.TonClientBlazor.Modules.Query;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using WebApplication.Utils;

namespace WebApplication.Pages
{
    public partial class TonContract
    {
        private const int ProgressTotalSteps = 7;

        [Inject] private ITonClient TonClient { get; set; }
        [Inject] private IJSRuntime JsRuntime { get; set; }
        [Inject] private IToastService ToastService { get; set; }

        private TonPublicSecretPair KeyPair { get; set; }
        private TonPackage ContractPackage { get; set; }
        private string FileName { get; set; }
        private string JsDataUri { get; set; }
        private string AccountAddress { get; set; }
        private bool FileLoader { get; set; }
        private bool SendingGramsSuccess { get; set; }
        private bool DeployContractResult { get; set; }
        private long? AccountBalance { get; set; }
        private int ProgressCurrentStep { get; set; }
        private string Mnemonic { get; set; }

        private async Task GenerateKeys()
        {
            KeyPair = await TonClient.Crypto.Ed25519Keypair();
            ProgressCurrentStep++;
        }

        private async Task LoadContract(InputFileChangeEventArgs e)
        {
            FileLoader = true;
            StateHasChanged();

            FileName = e.File.Name;

            await using Stream fileStream = e.File.OpenReadStream();
            await using var memoryStream = new MemoryStream();
            await fileStream.CopyToAsync(memoryStream);
            JsDataUri = $"data:{e.File.ContentType};base64,{Convert.ToBase64String(memoryStream.ToArray())}";

            try
            {
                ContractPackage = await JsRuntime.InvokeAsync<TonPackage>("getContactPackage", JsDataUri)
                    .CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            }
            catch (JSException)
            {
                JsDataUri = null;
                StateHasChanged();
                throw;
            }

            await Task.Delay(1000);
            FileLoader = false;
            ProgressCurrentStep++;
        }

        private async Task SendDeployMessage()
        {
            //create deploy message
            TonContractDeployMessage deployMessage = await TonClient.Contracts.CreateDeployMessage(new TonContractDeployParams
            {
                Package = ContractPackage,
                KeyPair = KeyPair
            }).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            AccountAddress = deployMessage.Address;
            ProgressCurrentStep++;
            StateHasChanged();

            //send deploy message
            TonMessageProcessingState messageProcessingState =
                await TonClient.Contracts.SendMessage(deployMessage.Message).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            ToastService.ShowSuccess("Message has been processed");
            ProgressCurrentStep++;
        }

        private async Task SendGrams()
        {
            //send some grams from giver
            TonContractRunResult result = await TonClient.Contracts.Run(new TonContractRunParams
            {
                Abi = Static.GiverAbi,
                Address = Static.GiverAddress,
                FunctionName = "sendGrams",
                Input = new
                {
                    dest = AccountAddress,
                    amount = 100000
                }
            }).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            if (!result.Transaction.Compute.Success)
            {
                ToastService.ShowError(JsonSerializer.Serialize(result.Transaction));
                return;
            }

            SendingGramsSuccess = result.Transaction.Compute.Success;
            ToastService.ShowSuccess($"GasFees:{result.Fees.GasFee}", "Sending grams is ok");
            ProgressCurrentStep++;
            StateHasChanged();

            var res = await TonClient.Queries.Accounts.Query(new TonQueryParams(new {id = new {eq = AccountAddress}}, "balance"))
                .CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            AccountBalance = res[0].Balance!.Value;
        }

        private async Task Deploy()
        {
            //deploy contract
            TonContractDeployResult deploy = await TonClient.Contracts.Deploy(new TonContractDeployParams
            {
                Package = ContractPackage,
                KeyPair = KeyPair
            }).CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            if (deploy.AlreadyDeployed)
            {
                ToastService.ShowWarning("Contract already deployed");
                ProgressCurrentStep++;
                DeployContractResult = true;
                return;
            }

            if (deploy.Transaction?.Compute?.Success ?? false)
            {
                ToastService.ShowSuccess($"GasFees:{deploy.Transaction.Compute.GasFees}", "Contract has been deployed");
                ProgressCurrentStep++;
                DeployContractResult = true;
                return;
            }

            ToastService.ShowError(JsonSerializer.Serialize(deploy), "Something went wrong");
        }

        private async Task Restore()
        {
            var mnemonicIsValid = await TonClient.Crypto.MnemonicIsValid(new TonMnemonicIsValidParams(Mnemonic??string.Empty))
                .CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            if (!mnemonicIsValid)
            {
                ToastService.ShowError("Master phrase in invalid!");
                return;
            }

            KeyPair = await TonClient.Crypto.MnemonicDeriveSignKeys(new TonMnemonicDeriveSignKeysParams(Mnemonic))
                .CatchJsExceptionAsync(ex => ToastService.ShowError(ex.Message));
            ProgressCurrentStep++;
        }

        private void Restart()
        {
            KeyPair = null;
            ContractPackage = null;
            FileName = null;
            JsDataUri = null;
            AccountAddress = null;
            FileLoader = false;
            SendingGramsSuccess = false;
            DeployContractResult = false;
            AccountBalance = null;
            ProgressCurrentStep = 0;
            Mnemonic = null;
        }
    }
}