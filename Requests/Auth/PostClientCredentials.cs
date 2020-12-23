using osu.API.Client.Auth;
using osu.API.Data.Auth;
using osu.API.Requests.UrlParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Auth {
    public class PostClientCredentials : PostRequest<ClientCredentialsGrantResponse> {
        public PostClientCredentials(ClientCredentialsGrant credentials) {
            BaseUrl = "https://osu.ppy.sh";

            UrlParameters.Add(new OAuthTokenParam());

            Headers = new Dictionary<string, string> {
                { "client_id", credentials.Id.ToString() },
                { "client_secret", credentials.Secret },
                { "grant_type", "client_credentials" },
                { "scope", "public" }
            };
        }
    }
}
