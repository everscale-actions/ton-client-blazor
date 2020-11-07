using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor
{
    public class TonInputMessage
    {
        [JsonPropertyName("text")] public string Text { get; set; }

        [JsonPropertyName("hex")] public string Hex { get; set; }

        [JsonPropertyName("base64")] public string Base64 { get; set; }

        public static implicit operator TonInputMessage(string text)
        {
            return new TonInputMessage
            {
                Text = text
            };
        }
    }
}