using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonAccessKeyRestrictions
    {
        [JsonPropertyName("key")] public string Key { get; set; }

        [JsonPropertyName("restrictToAccounts")]
        public string[] RestrictToAccounts { get; set; }
    }
}