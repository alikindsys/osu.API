using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.UrlParams {
    public class OAuthTokenParam : UrlParam {
        public string Key { get; }

        public string Value { get; }

        public bool valueOnly { get; }

        public OAuthTokenParam() {
            Key = "oauth";
            Value = "token";
        }


    }
}
