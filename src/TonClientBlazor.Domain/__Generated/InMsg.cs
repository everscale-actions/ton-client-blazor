using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class InMsg
    {
        [JsonPropertyName("msg_id")] public string MsgId { get; set; }

        [JsonPropertyName("transaction_id")] public string TransactionId { get; set; }
    }
}