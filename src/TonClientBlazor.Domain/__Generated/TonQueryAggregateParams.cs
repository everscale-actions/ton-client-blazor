using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonQueryAggregateParams
    {
        [JsonPropertyName("fields")] public Field[] Fields { get; set; }

        [JsonPropertyName("filter")] public object Filter { get; set; }
    }
}