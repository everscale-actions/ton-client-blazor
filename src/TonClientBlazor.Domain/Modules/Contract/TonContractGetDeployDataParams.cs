using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetDeployDataParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("imageBase64")] public string ImageBase64 { get; set; }

        [JsonPropertyName("initParams")] public object InitParams { get; set; }

        [JsonPropertyName("publicKeyHex")] public string PublicKeyHex { get; set; }

        [JsonPropertyName("workchainId")] public double? WorkchainId { get; set; }
    }
}