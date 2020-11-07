using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.Modules.Query
{
    public class TonQueryParams
    {
        public TonQueryParams(object filter, string result)
        {
            Filter = filter;
            Result = result;
        }

        [JsonPropertyName("filter")] public object Filter { get; set; }

        [JsonPropertyName("limit")] public double? Limit { get; set; }

        [JsonPropertyName("operationId")] public string OperationId { get; set; }

        [JsonPropertyName("orderBy")] public OrderByElement[] OrderBy { get; set; }
        [JsonPropertyName("result")] public string Result { get; set; }

        [JsonPropertyName("timeout")] public double? Timeout { get; set; }
    }
}