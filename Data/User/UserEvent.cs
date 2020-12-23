using Newtonsoft.Json;
using osu.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data.User {
    public class UserEvent {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("type")]
        private string TypeObject {
            set => Type = (UserEventType)Enum.Parse(typeof(UserEventType), value, true);
        }

        public UserEventType Type { get; set; }

        [JsonProperty("scoreRank")]
        private string ScoreRankObject {
            set => ScoreRank = (ScoreGrade)Enum.Parse(typeof(ScoreGrade), value);
        }

        public ScoreGrade ScoreRank { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("approval")]
        public UserBeatmapApproval Approval { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("beatmap")]
        public UserEventBeatmap Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public UserEventBeatmap Beatmapset { get; set; }

        [JsonProperty("user")]
        public UserEventUser User { get; set; }

        [JsonProperty("achievement")]
        public UserEventAchievement Achievement { get; set; }
    }
}
