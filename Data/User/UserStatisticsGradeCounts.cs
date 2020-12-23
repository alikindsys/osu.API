using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserStatisticsGradeCounts {
        [JsonProperty("ss")] public int SS { get; set; }
        [JsonProperty("ssh")] public int SSH { get; set; }
        [JsonProperty("s")] public int S { get; set; }
        [JsonProperty("sh")] public int SH { get; set; }
        [JsonProperty("a")] public int A { get; set; }
    }
}
