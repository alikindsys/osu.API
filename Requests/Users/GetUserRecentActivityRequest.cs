using osu.API.Data;
using osu.API.Extensions;
using osu.API.Requests.Parameters;
using osu.API.Requests.QueryParams;
using osu.API.Requests.UrlFragments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Users {
    public class GetUserRecentActivityRequest : AuthenticatedGetRequest<List<UserEvent>> {
        public GetUserRecentActivityRequest(UserUrlParam user, string accessToken) : base(accessToken) {
            UrlParameters.Add(user);
            UrlFragments.Add(new RecentActivityFragment());
        }

        public GetUserRecentActivityRequest(UserUrlParam user, string accessToken,
            LimitQueryParam limit = null, OffsetQueryParam offset = null
            ) : base(accessToken) {
            UrlParameters.Add(user);
            UrlFragments.Add(new RecentActivityFragment());

            QueryParameters.AddOptional(limit);
            QueryParameters.AddOptional(offset);
        }

        public GetUserRecentActivityRequest(ulong userId, string accessToken)
            : this(new UserUrlParam(userId), accessToken) {

        }

        public GetUserRecentActivityRequest(ulong userId, string accessToken, int limit = 5, int offset = 0)
            : this(new UserUrlParam(userId), accessToken, new LimitQueryParam(limit), new OffsetQueryParam(offset)) {

        }
    }
}
