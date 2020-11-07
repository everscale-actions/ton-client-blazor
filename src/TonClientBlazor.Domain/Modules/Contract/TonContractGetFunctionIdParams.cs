using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetFunctionIdParams
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("function")] public string Function { get; set; }

        [JsonPropertyName("input")] public bool Input { get; set; }
    }
}