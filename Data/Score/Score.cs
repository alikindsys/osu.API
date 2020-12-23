using Newtonsoft.Json;
using osu.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class Score {
        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("best_id")]
        public ulong? BestId { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("mods")]
        public string[] Mods { get; set; }

        [JsonProperty("score")]
        public int Score_ { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("statistics")]
        public ScoreStatistics Statistics { get; set; }

        [JsonProperty("pp")]
        public double? PP { get; set; }

        [JsonProperty("rank")]
        public ScoreGrade Grade { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("mode")]
        public string ModeName { get; set; }

        [JsonProperty("mode_int")]
        public Gamemode Mode { get; set; }

        [JsonProperty("replay")]
        public bool ReplayAvailable { get; set; }

        [JsonProperty("beatmap")]
        public Beatmap Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public Beatmapset Beatmapset { get; set; }

        [JsonProperty("weight")]
        public ScoreWeighting Weight { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
