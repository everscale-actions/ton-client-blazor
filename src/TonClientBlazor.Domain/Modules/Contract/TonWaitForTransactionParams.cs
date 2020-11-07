using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonWaitForTransactionParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("functionName")] public string FunctionName { get; set; }

        [JsonPropertyName("infiniteWait")] public bool? InfiniteWait { get; set; }

        [JsonPropertyName("message")] public TonMessage Message { get; set; }

        [JsonPropertyName("messageProcessingState")]
        public TonMessageProcessingState MessageProcessingState { get; set; }
    }
}