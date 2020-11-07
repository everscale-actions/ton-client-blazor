using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCreateSignedMessageParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("publicKeyHex")] public string PublicKeyHex { get; set; }

        [JsonPropertyName("signBytesBase64")] public string SignBytesBase64 { get; set; }

        [JsonPropertyName("unsignedBytesBase64")]
        public string UnsignedBytesBase64 { get; set; }
    }
}