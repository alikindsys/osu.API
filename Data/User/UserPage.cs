using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserPage
    {
        [JsonProperty("html")] public string Html { get; set; }
        [JsonProperty("raw")] public string Raw { get; set; }
    }
}
