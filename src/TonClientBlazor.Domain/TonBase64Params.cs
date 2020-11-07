using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonBase64Params
    {
        [JsonPropertyName("bounce")] public bool Bounce { get; set; }

        [JsonPropertyName("test")] public bool Test { get; set; }

        [JsonPropertyName("url")] public bool Url { get; set; }
    }
}