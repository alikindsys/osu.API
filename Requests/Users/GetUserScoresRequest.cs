using osu.API.Data;
using osu.API.Data.Enums;
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

        public GetUserScoresRequest(ulong userId, ScoreType type, string accessToken)
            : this(new UserUrlParam(userId) , new ScoreTypeUrlParam(type), accessToken) {

        }

        public GetUserScoresRequest(ulong userId, ScoreType type, string accessToken,
            bool includeFails = false, Gamemode mode = Gamemode.osu, int limit = 5, int offset = 0
            )
           : this(new UserUrlParam(userId), new ScoreTypeUrlParam(type), accessToken,
                 new IncludeFailsQueyParam(includeFails), new ModeQueryParam(mode),
                 new LimitQueryParam(limit), new OffsetQueryParam(offset)
                 ) {

        }
    }
}
