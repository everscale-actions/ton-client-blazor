using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCreateRunBodyParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("function")] public string Function { get; set; }

        [JsonPropertyName("header")] public object Header { get; set; }

        [JsonPropertyName("internal")] public bool? Internal { get; set; }

        [JsonPropertyName("keyPair")] public TonPublicSecretPair KeyPair { get; set; }

        [JsonPropertyName("params")] public object Params { get; set; }

        [JsonPropertyName("signingBox")] public object SigningBox { get; set; }
    }
}