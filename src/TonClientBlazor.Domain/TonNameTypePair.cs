using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonNameTypePair
    {
        [JsonConstructor]
        public TonNameTypePair()
        {
        }

        public TonNameTypePair(string name, string type)
        {
            Name = name;
            Type = type;
        }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }
    }
}