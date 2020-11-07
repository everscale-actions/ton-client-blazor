using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractRunResult : ITonClientResponseType
    {
        [JsonPropertyName("fees")] public TonFees Fees { get; set; }

        [JsonPropertyName("output")] public object Output { get; set; }

        [JsonPropertyName("transaction")] public TonTransaction Transaction { get; set; }
    }
}