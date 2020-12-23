using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserKudosu {
        [JsonProperty("total")] public int Total { get; set; }
        [JsonProperty("available")] public int Available { get; set; }
    }
}
