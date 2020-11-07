using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetCodeFromImageParams
    {
        [JsonPropertyName("imageBase64")] public string ImageBase64 { get; set; }
    }
}