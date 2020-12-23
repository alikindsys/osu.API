using Newtonsoft.Json;
using System;

namespace osu.API.Data {
    public class UserBadge
    {
        [JsonProperty("awarded_at")] public DateTime AwardedAt { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("image_url")] public string ImageUrl { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
    }
}
