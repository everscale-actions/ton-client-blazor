using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class OrderBy
    {
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; }

        [JsonPropertyName("path")] public string Path { get; set; }
    }
}