using Newtonsoft.Json;

namespace osu.API.Data {
    public class UserCountry
    {
        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }
}
