using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data.Auth {
    public class ClientCredentialsGrantResponse {
        [JsonProperty("token_type")] public string Type { get; set; }
        [JsonProperty("expires_in")] public int ExpiresIn { get; set; }
        [JsonProperty("access_token")] public string Token { get; set; }
    }
}
