using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonNaclBoxParams
    {
        [JsonPropertyName("message")] public TonNaclBoxParamsMessage Message { get; set; }

        [JsonPropertyName("nonce")] public string Nonce { get; set; }

        [JsonPropertyName("outputEncoding")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TonOutputEncodingType OutputEncoding { get; set; } = TonOutputEncodingType.Hex;

        [JsonPropertyName("secretKey")] public string SecretKey { get; set; }

        [JsonPropertyName("theirPublicKey")] public string TheirPublicKey { get; set; }
    }
}