using System;
using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonAbi
    {
        [JsonPropertyName("ABI version")] public double AbiVersion { get; set; }

        [JsonPropertyName("data")] public TonData[] Data { get; set; } = Array.Empty<TonData>();

        [JsonPropertyName("events")] public TonEvent[] Events { get; set; } = Array.Empty<TonEvent>();

        [JsonPropertyName("functions")] public TonFunction[] Functions { get; set; } = Array.Empty<TonFunction>();

        [JsonPropertyName("header")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[] Header { get; set; } = null;

        [JsonPropertyName("setTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SetTime { get; set; }
    }
}