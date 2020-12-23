using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserStatistics
    {
        [JsonProperty("level")] public UserStatisticsLevel Level { get; set; }
        [JsonProperty("pp")] public float pp { get; set; }
        [JsonProperty("pp_rank")] public int ppRank { get; set; }
        [JsonProperty("ranked_score")] public long RankedScore { get; set; }
        [JsonProperty("hit_accuracy")] public float HitAccuracy { get; set; }
        [JsonProperty("play_count")] public int PlayCount { get; set; }
        [JsonProperty("play_time")] public int PlayTime { get; set; }
        [JsonProperty("total_score")] public long TotalScore { get; set; }
        [JsonProperty("total_hits")] public int TotalHits { get; set; }
        [JsonProperty("maximum_combo")] public int MaximumCombo { get; set; }
        [JsonProperty("replays_watched_by_others")] public int ReplaysWatchedByOthers { get; set; }
        [JsonProperty("is_ranked")] public bool IsRanked { get; set; }
        [JsonProperty("grade_counts")] public UserStatisticsGradeCounts GradeCounts { get; set; }
        [JsonProperty("rank")] public UserStatisticsRank Rank { get; set; }
    }
}
