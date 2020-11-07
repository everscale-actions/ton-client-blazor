using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class Key
    {
        [JsonPropertyName("key")] public string KeyKey { get; set; }

        [JsonPropertyName("restrictToAccounts")]
        public string[] RestrictToAccounts { get; set; }
    }
}