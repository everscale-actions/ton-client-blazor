using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Attributes;

namespace ch1seL.TonClientBlazor
{
    [GraphQlNamespace(Namespace = "blocks")]
    public class TonBlock : ITonGraphQLResponseType
    {
        [JsonPropertyName("gen_utime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? GenUtime { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("in_msg_descr")] public InMsgDescr[] InMsgDescr { get; set; }

        [JsonPropertyName("shard")] public string Shard { get; set; }

        [JsonPropertyName("tr_count")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? TrCount { get; set; }

        [JsonPropertyName("workchain_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? WorkchainId { get; set; }
    }
}