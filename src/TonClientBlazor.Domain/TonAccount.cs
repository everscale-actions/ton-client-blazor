using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Attributes;
using ch1seL.TonClientBlazor.Utils;

namespace ch1seL.TonClientBlazor
{
    [GraphQlNamespace(Namespace = "accounts")]
    public class TonAccount : ITonClientResponseType, ITonGraphQLResponseType
    {
        [JsonPropertyName("acc_type")] public double? AccType { get; set; }

        [JsonPropertyName("balance")]
        [JsonConverter(typeof(HexStringToNullableDecConverter))]
        public long? Balance { get; set; }

        [JsonPropertyName("boc")] public string Boc { get; set; }

        [JsonPropertyName("code_hash")] public string CodeHash { get; set; }

        [JsonPropertyName("data_hash")] public string DataHash { get; set; }

        [JsonPropertyName("due_payment")] public string DuePayment { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("last_paid")] public double? LastPaid { get; set; }

        [JsonPropertyName("last_trans_lt")] public string LastTransLt { get; set; }

        [JsonPropertyName("library")] public string Library { get; set; }

        [JsonPropertyName("split_depth")] public double? SplitDepth { get; set; }

        [JsonPropertyName("tick")] public bool? Tick { get; set; }

        [JsonPropertyName("tock")] public bool? Tock { get; set; }
    }

    public class HexStringToNullableDecConverter : JsonConverter<long?>
    {
        public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.Null => null,
                JsonTokenType.String => reader.GetString().HexToDec(),
                _ => throw new NotSupportedException($"{reader.TokenType} is not support")
            };
        }

        public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value?.ToString("X"));
            else
                writer.WriteNullValue();
        }
    }
}