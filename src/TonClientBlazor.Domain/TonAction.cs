using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonAction
    {
        [JsonPropertyName("no_funds")] public bool? NoFunds { get; set; }

        [JsonPropertyName("result_code")] public double? ResultCode { get; set; }

        [JsonPropertyName("success")] public bool? Success { get; set; }

        [JsonPropertyName("valid")] public bool? Valid { get; set; }
    }
}