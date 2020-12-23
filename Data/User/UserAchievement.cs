using Newtonsoft.Json;
using System;

namespace osu.API.Data{
    public class UserAchievement
    {
        [JsonProperty("achieved_at")] public DateTime AchievedAt { get; set; }
        [JsonProperty("achievement_id")] public int AchievementId { get; set; }
    }
}
