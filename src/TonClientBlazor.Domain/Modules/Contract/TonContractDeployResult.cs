using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractDeployResult : ITonClientResponseType
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("alreadyDeployed")] public bool AlreadyDeployed { get; set; }

        [JsonPropertyName("transaction")] public TonTransaction Transaction { get; set; }
    }
}