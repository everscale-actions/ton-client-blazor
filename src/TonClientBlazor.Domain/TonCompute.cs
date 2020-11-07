using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonCompute
    {
        [JsonPropertyName("compute_type")] public double? ComputeType { get; set; }

        [JsonPropertyName("exit_code")] public double ExitCode { get; set; }

        [JsonPropertyName("gas_fees")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? GasFees { get; set; }

        [JsonPropertyName("skipped_reason")] public double? SkippedReason { get; set; }

        [JsonPropertyName("success")] public bool Success { get; set; }

        [JsonPropertyName("total_fwd_fees")] public string TotalFwdFees { get; set; }
    }
}