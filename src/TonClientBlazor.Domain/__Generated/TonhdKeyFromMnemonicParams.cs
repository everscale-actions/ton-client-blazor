using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TondKeyFromMnemonicParams
    {
        [JsonPropertyName("dictionary")] public double? Dictionary { get; set; }

        [JsonPropertyName("phrase")] public string Phrase { get; set; }

        [JsonPropertyName("wordCount")] public double? WordCount { get; set; }
    }
}