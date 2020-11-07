using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractDecodeMessageBodyParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("bodyBase64")] public string BodyBase64 { get; set; }

        [JsonPropertyName("internal")] public bool? Internal { get; set; }
    }
}