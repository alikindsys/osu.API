using osu.API.Data;
using osu.API.Extensions;
using osu.API.Requests.Parameters;
using osu.API.Requests.QueryParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Users {
    public class GetUserBeatmapsRequest : AuthenticatedGetRequest<List<Beatmapset>> {
        public GetUserBeatmapsRequest(UserUrlParam user, BeatmapsetTypeUrlParam type, string accessToken) : base(accessToken) {
            UrlParameters.Add(user);
            UrlParameters.Add(type);
        }
        public GetUserBeatmapsRequest(UserUrlParam user, BeatmapsetTypeUrlParam type, string accessToken,
                LimitQueryParam limit = null, OffsetQueryParam offset = null
            ) : base(accessToken) {
            UrlParameters.Add(user);
            UrlParameters.Add(type);

            QueryParameters.AddOptional(limit);
            QueryParameters.AddOptional(offset);
        }
    }
}
