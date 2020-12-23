using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserRankHistory
    {
        [JsonProperty("mode")] public string Mode { get; set; }
        [JsonProperty("data")] public int[] Data { get; set; }
    }
}
