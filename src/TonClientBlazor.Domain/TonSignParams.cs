using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonSignParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("bytesToSignBase64")]
        public string BytesToSignBase64 { get; set; }

        [JsonPropertyName("expire")] public double? Expire { get; set; }

        [JsonPropertyName("unsignedBytesBase64")]
        public string UnsignedBytesBase64 { get; set; }
    }
}