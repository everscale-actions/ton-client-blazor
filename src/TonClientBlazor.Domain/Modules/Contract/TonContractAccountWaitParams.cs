using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractAccountWaitParams
    {
        [JsonPropertyName("timeout")] public double? Timeout { get; set; }

        [JsonPropertyName("transactionLt")] public string TransactionLt { get; set; }
    }
}