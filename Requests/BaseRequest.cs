using Newtonsoft.Json;
using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public abstract class BaseRequest<T> {
        internal string BaseUrl = "https://osu.ppy.sh/api/v2";
        public List<QueryParam> QueryParameters { get; set; } = new();
        public List<UrlParam> UrlParameters { get; set; } = new();

        public Dictionary<string, string> Headers {get;set;} = new();

        public string Url => string.Join("/", UrlParameters.Select(x => $"{(x.valueOnly ? $"{x.Value}" : $"{x.Key}/{x.Value}")}"));
        public string Query => string.Join("&", QueryParameters.Select(x => $"{x.Key}={x.Value}"));
        public string RequestUrl => $"{BaseUrl}/{Url}?{Query}";

    }
}
