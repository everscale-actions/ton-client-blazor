using System.Text.Json.Serialization;

namespace ch1seL.TonClientBlazor.__Generated
{
    public class Descr
    {
        [JsonPropertyName("before_merge")] public bool BeforeMerge { get; set; }

        [JsonPropertyName("before_split")] public bool BeforeSplit { get; set; }

        [JsonPropertyName("end_lt")] public string EndLt { get; set; }

        [JsonPropertyName("fees_collected")] public string FeesCollected { get; set; }

        [JsonPropertyName("file_hash")] public string FileHash { get; set; }

        [JsonPropertyName("flags")] public double Flags { get; set; }

        [JsonPropertyName("funds_created")] public string FundsCreated { get; set; }

        [JsonPropertyName("gen_utime")] public double GenUtime { get; set; }

        [JsonPropertyName("min_ref_mc_seqno")] public double MinRefMcSeqno { get; set; }

        [JsonPropertyName("next_catchain_seqno")]
        public double NextCatchainSeqno { get; set; }

        [JsonPropertyName("next_validator_shard")]
        public string NextValidatorShard { get; set; }

        [JsonPropertyName("nx_cc_updated")] public bool NxCcUpdated { get; set; }

        [JsonPropertyName("reg_mc_seqno")] public double RegMcSeqno { get; set; }

        [JsonPropertyName("root_hash")] public string RootHash { get; set; }

        [JsonPropertyName("seq_no")] public double SeqNo { get; set; }

        [JsonPropertyName("split")] public double Split { get; set; }

        [JsonPropertyName("split_type")] public double SplitType { get; set; }

        [JsonPropertyName("start_lt")] public string StartLt { get; set; }

        [JsonPropertyName("want_merge")] public bool WantMerge { get; set; }

        [JsonPropertyName("want_split")] public bool WantSplit { get; set; }
    }
}