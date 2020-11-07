using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonQueryAggregateField
    {
        [JsonPropertyName("field")] public string Field { get; set; }

        [JsonPropertyName("fn")] public TonQueryAggregateFnTypeEnum Fn { get; set; }
    }
}