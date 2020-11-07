using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCalcRunFeeParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("functionName")] public string FunctionName { get; set; }

        [JsonPropertyName("header")] public object Header { get; set; }

        [JsonPropertyName("input")] public object Input { get; set; }

        [JsonPropertyName("keyPair")] public TonPublicSecretPair KeyPair { get; set; }

        [JsonPropertyName("signingBox")] public object SigningBox { get; set; }

        [JsonPropertyName("emulateBalance")] public bool? EmulateBalance { get; set; }

        [JsonPropertyName("waitParams")] public TonWaitParams WaitParams { get; set; }
    }
}