using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Attributes;

namespace ch1seL.TonClientBlazor
{
    [GraphQlNamespace(Namespace = "transactions")]
    public class TonTransaction : ITonClientResponseType, ITonGraphQLResponseType
    {
        [JsonPropertyName("aborted")] public bool? Aborted { get; set; }

        [JsonPropertyName("account_addr")] public string AccountAddr { get; set; }

        [JsonPropertyName("action")] public TonAction Action { get; set; }

        [JsonPropertyName("block_id")] public string BlockId { get; set; }
        [JsonPropertyName("compute")] public TonCompute Compute { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("in_msg")] public string InMsg { get; set; }

        [JsonPropertyName("lt")] public string Lt { get; set; }

        [JsonPropertyName("now")] public double? Now { get; set; }

        [JsonPropertyName("out_messages")] public TonOutMessage[] OutMessages { get; set; }

        [JsonPropertyName("out_msgs")] public string[] OutMsgs { get; set; }

        [JsonPropertyName("status")] public double? Status { get; set; }

        [JsonPropertyName("storage")] public TonStorage Storage { get; set; }

        [JsonPropertyName("tr_type")] public double? TrType { get; set; }
    }
}