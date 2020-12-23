using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserStatisticsRank
    {
        [JsonProperty("global")] public int Global { get; set; }
        [JsonProperty("country")] public int Country { get; set; }
    }
}
