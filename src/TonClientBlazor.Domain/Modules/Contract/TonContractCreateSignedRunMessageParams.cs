using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCreateSignedRunMessageParams
    {
        [JsonPropertyName("publicKeyHex")] public string PublicKeyHex { get; set; }

        [JsonPropertyName("signBytesBase64")] public string SignBytesBase64 { get; set; }

        [JsonPropertyName("unsignedMessage")] public TonUnsignedMessage UnsignedMessage { get; set; }
    }
}