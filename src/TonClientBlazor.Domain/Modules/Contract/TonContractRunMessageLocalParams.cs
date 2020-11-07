using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractRunMessageLocalParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("account")] public TonAccount Account { get; set; }

        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("fullRun")] public bool? FullRun { get; set; }

        [JsonPropertyName("functionName")] public string FunctionName { get; set; }

        [JsonPropertyName("messageBodyBase64")]
        public string MessageBodyBase64 { get; set; }

        [JsonPropertyName("waitParams")] public TonWaitParams WaitParams { get; set; }
    }
}