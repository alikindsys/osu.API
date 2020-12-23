using osu.API.Data.Auth;
using osu.API.Requests.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Client.Auth {
    public static class Authentication {
        public static async Task<ClientCredentialsGrantResponse> OAuthClientCredentialsAsync(ClientCredentialsGrant credentials, HttpClient client) {
            PostClientCredentials request = new(credentials);
            var response = await request.PostAsync(client);
            return response;
        }
    }
}
