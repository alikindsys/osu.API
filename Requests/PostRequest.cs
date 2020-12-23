using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public class PostRequest<T> : BaseRequest<T> {
        public async Task<T> PostAsync(HttpClient client) {
            var json = JsonConvert.SerializeObject(Headers);
            var content = new StringContent(json,Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(RequestUrl, content);
            if (responseMessage.IsSuccessStatusCode) {
                var response = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(response);
            }
            return default(T);
        }
    }
}
