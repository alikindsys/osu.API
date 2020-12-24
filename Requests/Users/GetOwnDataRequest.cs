using osu.API.Data;
using osu.API.Data.Enums;
using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Users {
    public class GetOwnDataRequest : AuthenticatedGetRequest<User> {
        public GetOwnDataRequest(string accessToken) : base(accessToken) {
            BaseUrl += "/me";
        }

        public GetOwnDataRequest(ModeUrlParam mode,string accessToken) : base(accessToken) {
            BaseUrl += "/me";
            UrlParameters.Add(mode);
        }

        public GetOwnDataRequest(Gamemode mode, string accessToken)
            : this(new ModeUrlParam(mode), accessToken)
            { }
    }
}
