using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCalcDeployFeeParams
    {
        [JsonPropertyName("constructorHeader")]
        public object ConstructorHeader { get; set; }

        [JsonPropertyName("constructorParams")]
        public object ConstructorParams { get; set; }

        [JsonPropertyName("initParams")] public object InitParams { get; set; }

        [JsonPropertyName("keyPair")] public TonPublicSecretPair KeyPair { get; set; }

        [JsonPropertyName("package")] public TonPackage Package { get; set; }

        [JsonPropertyName("signingBox")] public object SigningBox { get; set; }

        [JsonPropertyName("workchainId")] public double? WorkchainId { get; set; }

        [JsonPropertyName("emulateBalance")] public bool? EmulateBalance { get; set; }

        [JsonPropertyName("newAccount")] public bool? NewAccount { get; set; }
    }
}