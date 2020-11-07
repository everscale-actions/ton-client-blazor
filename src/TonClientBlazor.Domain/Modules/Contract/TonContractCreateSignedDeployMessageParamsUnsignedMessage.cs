using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCreateSignedDeployMessageParamsUnsignedMessage
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("signParams")] public TonSignParams SignParams { get; set; }
    }
}