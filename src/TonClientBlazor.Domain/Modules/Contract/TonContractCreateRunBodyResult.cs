using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractCreateRunBodyResult : ITonClientResponseType
    {
        [JsonPropertyName("bodyBase64")] public string BodyBase64 { get; set; }
    }
}