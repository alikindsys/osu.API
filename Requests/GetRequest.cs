using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public abstract class GetRequest<T> : BaseRequest<T>{
        public async Task<T> GetAsync(HttpClient client) {
            string response_string = await client.GetStringAsync(RequestUrl);
            return JsonConvert.DeserializeObject<T>(response_string);
        }
    }
}
