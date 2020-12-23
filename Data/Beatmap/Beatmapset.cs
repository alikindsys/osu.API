using Newtonsoft.Json;
using osu.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class Beatmapset {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("favourite_count")]
        public uint FavouriteCount { get; set; }

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("play_count")]
        public uint PlayCount { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public BeatmapsetStatus Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("video")]
        public bool HasVideo { get; set; }

        [JsonProperty("can_be_hyped")]
        public bool Hypeable { get; set; }

        [JsonProperty("discussion_enabled")]
        public bool Discussable { get; set; }

        [JsonProperty("discussion_locked")]
        public bool DiscussionLocked { get; set; }

        [JsonProperty("is_scoreable")]
        public bool Scoreable { get; set; }

        [JsonProperty("storyboard")]
        public bool HasStoryboard { get; set; }

        [JsonProperty("submission_date")]
        public DateTimeOffset SubmissionDate { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdate { get; set; }

        [JsonProperty("ranked_date")]
        public DateTimeOffset? RankedDate { get; set; }

        [JsonProperty("legacy_thread_url")]
        public string LegacyThreadUrl { get; set; }

        [JsonProperty("tags")]
        private string TagsObject {
            set => Tags = value.Split(' ');
        }

        public string[] Tags { get; set; }

        [JsonProperty("ranked")]
        public BeatmapsetStatus RankedStatus { get; set; }

        [JsonProperty("covers")]
        public BeatmapsetCovers Covers { get; set; }

        [JsonProperty("availability")]
        public BeatmapAvailability Availability { get; set; }

        [JsonProperty("hype")]
        public BeatmapRequirementMetric Hype { get; set; }

        [JsonProperty("nominations")]
        public BeatmapRequirementMetric Nominations { get; set; }

        [JsonProperty("beatmaps")]
        public IEnumerable<Beatmap> Beatmaps { get; set; }
    }
}
