using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Crypto
{
    public class TonCryptoChaCha20Params
    {
        [JsonPropertyName("data")] public string Data { get; set; }
        [JsonPropertyName("key")] public string Key { get; set; }
        [JsonPropertyName("nonce")] public string Nonce { get; set; }
    }
}