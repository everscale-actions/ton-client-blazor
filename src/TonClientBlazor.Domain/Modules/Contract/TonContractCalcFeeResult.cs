using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCalcFeeResult : ITonClientResponseType
    {
        [JsonPropertyName("fees")] public TonFees Fees { get; set; }
    }
}