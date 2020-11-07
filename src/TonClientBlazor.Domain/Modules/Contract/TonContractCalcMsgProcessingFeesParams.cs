using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCalcMsgProcessingFeesParams
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("emulateBalance")] public bool? EmulateBalance { get; set; }

        [JsonPropertyName("message")] public TonMessage Message { get; set; }

        [JsonPropertyName("newAccount")] public bool? NewAccount { get; set; }

        [JsonPropertyName("waitParams")] public TonWaitParams WaitParams { get; set; }
    }
}