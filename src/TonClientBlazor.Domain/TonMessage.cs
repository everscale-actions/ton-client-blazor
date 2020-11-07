using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Attributes;

namespace ch1seL.TonClientBlazor
{
    [GraphQlNamespace(Namespace = "messages")]
    public class TonMessage : ITonClientResponseType, ITonGraphQLResponseType
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("expire")] public double? Expire { get; set; }

        [JsonPropertyName("messageBodyBase64")]
        public string MessageBodyBase64 { get; set; }

        [JsonPropertyName("messageId")] public string MessageId { get; set; }
    }
}