using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonNaclBoxParamsMessage
    {
        [JsonPropertyName("base64")] public string Base64 { get; set; }

        [JsonPropertyName("hex")] public string Hex { get; set; }

        [JsonPropertyName("text")] public string Text { get; set; }
    }
}