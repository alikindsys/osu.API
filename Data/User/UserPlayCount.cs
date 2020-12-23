using Newtonsoft.Json;
using System;

namespace osu.API.Data {
    public class UserPlayCount
    {
        [JsonProperty("start_date")] public DateTime StartDate { get; set; }
        [JsonProperty("count")] public int Count { get; set; }
    }
}
