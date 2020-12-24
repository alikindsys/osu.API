using osu.API.Data;
using osu.API.Data.Enums;
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

        public GetUserRequest(ulong userId, string accessToken)
            : this (new UserUrlParam(userId), accessToken) {

        }

        public GetUserRequest(ulong userId, Gamemode mode , string accessToken)
            : this(new UserUrlParam(userId), new ModeUrlParam(mode), accessToken) {

        }
    }
}
