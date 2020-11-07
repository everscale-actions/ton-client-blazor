using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class TonAccessKeysManagementParams
    {
        [JsonPropertyName("account")] public string Account { get; set; }

        [JsonPropertyName("accountKeys")] public TonPublicSecretPair AccountKeys { get; set; }

        [JsonPropertyName("signedManagementAccessKey")]
        public string SignedManagementAccessKey { get; set; }
    }
}