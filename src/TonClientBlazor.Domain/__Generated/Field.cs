using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class Field
    {
        [JsonPropertyName("field")] public string FieldField { get; set; }

        [JsonPropertyName("fn")] public TonQueryAggregateFnTypeEnum Fn { get; set; }
    }
}