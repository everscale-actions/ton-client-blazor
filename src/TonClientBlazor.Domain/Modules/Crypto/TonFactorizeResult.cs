using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Crypto
{
    public class TonFactorizeResult : ITonClientResponseType
    {
        [JsonPropertyName("a")] public string A { get; set; }

        [JsonPropertyName("b")] public string B { get; set; }
    }
}