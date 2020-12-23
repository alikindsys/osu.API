using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public abstract class AuthenticatedPostRequest<T> : AuthenticatedRequest<T> {
        public AuthenticatedPostRequest(string accessToken) : base(accessToken) {
        }
        public async Task<T> PostAsync(HttpClient client) {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            var json = JsonConvert.SerializeObject(Headers);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(RequestUrl, content);
            if (responseMessage.IsSuccessStatusCode) {
                var response = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(response);
            }
            return default(T);
        }
    }
}
