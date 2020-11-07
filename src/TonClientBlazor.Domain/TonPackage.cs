using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonPackage
    {
        [JsonPropertyName("abi")] public TonAbi Abi { get; set; }

        [JsonPropertyName("imageBase64")] public string ImageBase64 { get; set; }
    }
}