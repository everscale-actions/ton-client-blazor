using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetFunctionIdResult : ITonClientResponseType
    {
        [JsonPropertyName("id")] public double Id { get; set; }
    }
}