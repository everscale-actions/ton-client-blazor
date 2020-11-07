using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractConvertAddressParams
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("base64Params")] public TonBase64Params TonBase64Params { get; set; }

        [JsonPropertyName("convertTo")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TonAddressStringVariantTypeEnum ConvertTo { get; set; }
    }
}