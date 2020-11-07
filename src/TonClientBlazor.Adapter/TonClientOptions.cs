using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonClientOptions
    {
        [JsonPropertyName("servers")] public IReadOnlyCollection<string> Servers { get; set; }

        [JsonPropertyName("log_verbose")] public bool LogVerbose { get; set; }
    }
}