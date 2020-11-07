using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor.Modules.Contract
{
    public class TonContractGetDeployDataResult : ITonClientResponseType
    {
        [JsonPropertyName("accountId")] public string AccountId { get; set; }

        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("dataBase64")] public string DataBase64 { get; set; }

        [JsonPropertyName("imageBase64")] public string ImageBase64 { get; set; }
    }
}