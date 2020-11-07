using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Crypto
{
    public class TonMnemonicDeriveSignKeysParams
    {
        public TonMnemonicDeriveSignKeysParams(string phrase)
        {
            Phrase = phrase;
        }

        [JsonPropertyName("phrase")] public string Phrase { get; set; }

        [JsonPropertyName("compliant")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Compliant { get; set; }

        [JsonPropertyName("dictionary")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TonMnemonicDictionary? Dictionary { get; set; }

        [JsonPropertyName("path")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Path { get; set; }

        [JsonPropertyName("wordCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TonMnemonicWordCount? WordCount { get; set; }
    }
}