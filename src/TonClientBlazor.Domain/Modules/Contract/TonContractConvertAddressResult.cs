using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractConvertAddressResult : ITonClientResponseType
    {
        [JsonPropertyName("address")] public string Address { get; set; }
    }
}