using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonConfigData
    {
        [JsonPropertyName("accessKey")] public string AccessKey { get; set; }

        [JsonPropertyName("log_verbose")] public bool? LogVerbose { get; set; }

        [JsonPropertyName("messageExpirationTimeout")]
        public double? MessageExpirationTimeout { get; set; }

        [JsonPropertyName("messageExpirationTimeoutGrowFactor")]
        public double? MessageExpirationTimeoutGrowFactor { get; set; }

        [JsonPropertyName("messageProcessingTimeout")]
        public double? MessageProcessingTimeout { get; set; }

        [JsonPropertyName("messageRetriesCount")]
        public double? MessageRetriesCount { get; set; }

        [JsonPropertyName("networkTimeout")] public double? NetworkTimeout { get; set; }

        [JsonPropertyName("outOfSyncThreshold")]
        public double? OutOfSyncThreshold { get; set; }

        [JsonPropertyName("servers")] public string[] Servers { get; set; }

        [JsonPropertyName("useWebSocketForQueries")]
        public bool? UseWebSocketForQueries { get; set; }

        [JsonPropertyName("waitForTimeout")] public double? WaitForTimeout { get; set; }
    }
}