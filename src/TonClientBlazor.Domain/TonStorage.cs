using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonStorage
    {
        [JsonPropertyName("status_change")] public double? StatusChange { get; set; }

        [JsonPropertyName("storage_fees_collected")]
        public string StorageFeesCollected { get; set; }
    }
}