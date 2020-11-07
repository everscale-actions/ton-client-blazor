using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractRunGetParams
    {
        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("balance")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? Balance { get; set; }

        [JsonPropertyName("bocBase64")] public string BocBase64 { get; set; }

        [JsonPropertyName("codeBase64")] public string CodeBase64 { get; set; }

        [JsonPropertyName("dataBase64")] public string DataBase64 { get; set; }

        [JsonPropertyName("functionName")] public string FunctionName { get; set; }

        [JsonPropertyName("input")] public object Input { get; set; }

        [JsonPropertyName("last_paid")] public double? LastPaid { get; set; }
    }
}