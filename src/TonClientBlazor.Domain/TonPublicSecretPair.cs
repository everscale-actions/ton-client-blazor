using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor
{
    public class TonPublicSecretPair : ITonClientResponseType
    {
        [JsonPropertyName("public")] public string Public { get; set; }

        [JsonPropertyName("secret")] public string Secret { get; set; }
    }
}