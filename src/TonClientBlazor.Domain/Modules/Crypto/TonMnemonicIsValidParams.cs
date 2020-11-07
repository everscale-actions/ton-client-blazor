using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Crypto
{
    public class TonMnemonicIsValidParams
    {
        public TonMnemonicIsValidParams(string phrase)
        {
            Phrase = phrase;
        }

        [JsonPropertyName("phrase")] public string Phrase { get; set; }

        [JsonPropertyName("dictionary")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TonMnemonicDictionary? Dictionary { get; set; }

        [JsonPropertyName("wordCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TonMnemonicWordCount? WordCount { get; set; }
    }
}