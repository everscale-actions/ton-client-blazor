using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractDecodeMessageBodyResult : ITonClientResponseType
    {
        [JsonPropertyName("function")] public string Function { get; set; }

        [JsonPropertyName("output")] public object Output { get; set; }
    }
}