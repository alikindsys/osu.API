using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public class AuthenticatedGetRequest<T> : AuthenticatedRequest<T> {
        public AuthenticatedGetRequest(string accessToken) : base(accessToken) {
        }
        public async Task<T> GetAsync(HttpClient client) {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            string response_string = await client.GetStringAsync(RequestUrl);
            return JsonConvert.DeserializeObject<T>(response_string);
        }
    }
}
