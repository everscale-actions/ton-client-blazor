using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractRunGetResult : ITonClientResponseType
    {
        [JsonPropertyName("output")] public object Output { get; set; }
    }
}