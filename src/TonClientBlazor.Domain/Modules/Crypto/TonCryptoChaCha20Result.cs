using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Crypto
{
    public class TonCryptoChaCha20Result
    {
        [JsonPropertyName("data")] public string Data { get; set; }
    }
}