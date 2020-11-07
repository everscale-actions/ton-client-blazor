using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonFees
    {
        [JsonPropertyName("gasFee")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? GasFee { get; set; }

        [JsonPropertyName("inMsgFwdFee")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? InMsgFwdFee { get; set; }

        [JsonPropertyName("outMsgsFwdFee")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? OutMsgsFwdFee { get; set; }

        [JsonPropertyName("storageFee")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? StorageFee { get; set; }

        [JsonPropertyName("totalAccountFees")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? TotalAccountFees { get; set; }

        [JsonPropertyName("totalOutput")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? TotalOutput { get; set; }
    }
}