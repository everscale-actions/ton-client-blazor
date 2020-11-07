using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonNaclSecretBoxParams
    {
        [JsonPropertyName("key")] public string Key { get; set; }

        [JsonPropertyName("message")] public TonNaclSecretBoxParamsMessage Message { get; set; }

        [JsonPropertyName("nonce")] public string Nonce { get; set; }

        [JsonPropertyName("outputEncoding")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TonOutputEncodingType OutputEncoding { get; set; } = TonOutputEncodingType.Hex;
    }
}