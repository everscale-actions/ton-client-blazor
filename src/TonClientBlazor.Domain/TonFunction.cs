using System;
using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonFunction
    {
        [JsonConstructor]
        public TonFunction()
        {
        }

        public TonFunction(string name)
        {
            Name = name;
        }

        [JsonPropertyName("inputs")] public TonNameTypePair[] Inputs { get; set; } = Array.Empty<TonNameTypePair>();
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("outputs")] public TonNameTypePair[] Outputs { get; set; } = Array.Empty<TonNameTypePair>();
    }
}