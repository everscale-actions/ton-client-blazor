using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractUnsignedDeployMessage : ITonClientResponseType
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("signParams")] public TonSignParams SignParams { get; set; }
    }
}