using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;

namespace ch1seL.TonClientBlazor
{
    public class TonMessageProcessingState : ITonClientResponseType
    {
        [JsonPropertyName("lastBlockId")] public string LastBlockId { get; set; }

        [JsonPropertyName("sendingTime")] public double SendingTime { get; set; }
    }
}