using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetCodeFromImageResult : ITonClientResponseType
    {
        [JsonPropertyName("codeBase64")] public string CodeBase64 { get; set; }
    }
}