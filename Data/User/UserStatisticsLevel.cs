using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserStatisticsLevel
    {
        [JsonProperty("current")] public int Current { get; set; }
        [JsonProperty("progress")] public int Progress { get; set; }
    }
}
