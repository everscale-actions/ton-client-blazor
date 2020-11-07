using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonWaitForParams
    {
        [JsonPropertyName("filter")] public object Filter { get; set; }

        [JsonPropertyName("operationId")] public string OperationId { get; set; }

        [JsonPropertyName("result")] public string Result { get; set; }

        [JsonPropertyName("timeout")] public double? Timeout { get; set; }
    }
}