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
    public class GetUserScoresRequest : AuthenticatedGetRequest<List<Score>> {
        public GetUserScoresRequest(UserUrlParam user, ScoreTypeUrlParam type, string accessToken) : base (accessToken) {
            UrlParameters.Add(user);
            UrlParameters.Add(type);
        }
        public GetUserScoresRequest(UserUrlParam user, ScoreTypeUrlParam type, string accessToken,
            IncludeFailsQueyParam includeFails = null, ModeQueryParam mode = null,
            LimitQueryParam limit = null, OffsetQueryParam offset = null
            ) : base(accessToken) {
            UrlParameters.Add(user);
            UrlParameters.Add(type);

            QueryParameters.AddOptional(includeFails);
            QueryParameters.AddOptional(mode);
            QueryParameters.AddOptional(limit);
            QueryParameters.AddOptional(offset);
        }
    }
}
