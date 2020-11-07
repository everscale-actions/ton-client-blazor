using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractLoadParams
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("includeImage")] public bool IncludeImage { get; set; }
    }
}