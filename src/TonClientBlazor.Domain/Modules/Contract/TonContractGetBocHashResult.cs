using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetBocHashResult
    {
        [JsonPropertyName("hash")] public string Hash { get; set; }
    }
}