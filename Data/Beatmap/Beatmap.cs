using Newtonsoft.Json;
using osu.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class Beatmap {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("beatmapset_id")]
        public uint BeatmapsetId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        //todo check json
        public string Hash { get; set; }

        [JsonProperty("ranked")]
        public BeatmapsetStatus Ranked { get; set; }

        [JsonProperty("mode")]
        public string ModeName { get; set; }

        [JsonProperty("mode_int")]
        public Gamemode Mode { get; set; }

        [JsonProperty("convert")]
        public bool IsConverted { get; set; }

        [JsonProperty("ar")]
        public double AR { get; set; }

        [JsonProperty("cs")]
        public double CS { get; set; }

        [JsonProperty("drain")]
        public double Drain { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }

        [JsonProperty("bpm")]
        public double BPM { get; set; }

        [JsonProperty("count_circles")]
        public uint CountCircles { get; set; }

        [JsonProperty("count_sliders")]
        public uint CountSliders { get; set; }

        [JsonProperty("count_spinners")]
        public uint CountSpinners { get; set; }

        [JsonProperty("count_total")]
        public uint CountTotal { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("hit_length")]
        public long HitLength { get; set; }

        [JsonProperty("is_scoreable")]
        public bool IsScoreable { get; set; }

        [JsonProperty("passcount")]
        public long Passcount { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_length")]
        public long TotalLength { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("max_combo")]
        public uint? MaxCombo { get; set; }

        [JsonProperty("failtimes")]
        public BeatmapFailMetrics Fails { get; set; }

        [JsonProperty("ratings")]
        public IEnumerable<uint> Ratings { get; set; }
    }
}
