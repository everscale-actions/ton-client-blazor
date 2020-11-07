using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonUnsignedMessage
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("functionName")] public string FunctionName { get; set; }

        [JsonPropertyName("signParams")] public TonSignParams SignParams { get; set; }
    }
}