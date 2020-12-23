using Newtonsoft.Json;
using System;

namespace osu.API.Data {
    public class UserWatchedCount
    {
        [JsonProperty("start_date")] public DateTime StartDate { get; set; }
        [JsonProperty("count")] public int Count { get; set; }
    }
}
