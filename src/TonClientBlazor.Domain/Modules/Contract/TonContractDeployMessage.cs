using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractDeployMessage : ITonClientResponseType
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("message")] public TonMessage Message { get; set; }
    }
}