using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class QShardHash
    {
        [JsonPropertyName("descr")] public Descr Descr { get; set; }

        [JsonPropertyName("shard")] public string Shard { get; set; }

        [JsonPropertyName("workchain_id")] public double WorkchainId { get; set; }
    }
}