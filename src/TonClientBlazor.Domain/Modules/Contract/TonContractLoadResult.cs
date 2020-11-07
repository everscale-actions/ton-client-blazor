using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractLoadResult : ITonClientResponseType
    {
        [JsonPropertyName("balanceGrams")] public string BalanceGrams { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }
    }
}