using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonEvent
    {
        [JsonPropertyName("inputs")] public TonNameTypePair[] Inputs { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }
    }
}