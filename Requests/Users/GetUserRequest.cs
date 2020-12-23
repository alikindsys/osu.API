using osu.API.Data;
using osu.API.Requests.Parameters;
using System.Collections.Generic;

namespace osu.API.Requests.Users {
    public class GetUserRequest : AuthenticatedGetRequest<User> {
        public GetUserRequest(UserUrlParam user, string accessToken) : base(accessToken) {
            UrlParameters.Add(user);
        }

        public GetUserRequest(UserUrlParam user, ModeUrlParam mode, string accessToken) : base(accessToken) {
            UrlParameters.Add(user);
            UrlParameters.Add(mode);
        }
    }
}
