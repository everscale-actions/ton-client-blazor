using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonScryptParams
    {
        [JsonPropertyName("dkLen")] public double DkLen { get; set; }

        [JsonPropertyName("logN")] public double LogN { get; set; }

        [JsonPropertyName("outputEncoding")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TonOutputEncodingType OutputEncoding { get; set; } = TonOutputEncodingType.Hex;

        [JsonPropertyName("p")] public double P { get; set; }

        [JsonPropertyName("password")] public TonInputMessage Password { get; set; }

        [JsonPropertyName("r")] public double R { get; set; }

        [JsonPropertyName("salt")] public TonInputMessage Salt { get; set; }
    }
}