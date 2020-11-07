using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonOutMessage
    {
        [JsonPropertyName("body")] public string Body { get; set; }

        [JsonPropertyName("created_at")] public double? CreatedAt { get; set; }

        [JsonPropertyName("dst")] public string Dst { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("msg_type")] public double? MsgType { get; set; }

        [JsonPropertyName("src")] public string Src { get; set; }

        [JsonPropertyName("status")] public double? Status { get; set; }
    }
}