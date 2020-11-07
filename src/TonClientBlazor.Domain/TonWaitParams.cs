using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonWaitParams
    {
        [JsonPropertyName("timeout")] public double? Timeout { get; set; }

        [JsonPropertyName("transactionLt")] public string TransactionLt { get; set; }
    }
}