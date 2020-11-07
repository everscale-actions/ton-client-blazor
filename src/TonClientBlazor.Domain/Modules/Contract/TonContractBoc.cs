using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractBoc
    {
        [JsonPropertyName("bocBase64")] public string BocBase64 { get; set; }
    }
}