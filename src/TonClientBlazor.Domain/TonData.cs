using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonData
    {
        [JsonPropertyName("key")] public double Key { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }
    }
}