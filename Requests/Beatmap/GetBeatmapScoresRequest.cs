using osu.API.Data;
using osu.API.Extensions;
using osu.API.Requests.QueryParams;
using osu.API.Requests.UrlFragments;
using osu.API.Requests.UrlParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Beatmap {
    public class GetBeatmapScoresRequest : AuthenticatedGetRequest<BeatmapScores> {
        public GetBeatmapScoresRequest(BeatmapUrlParam beatmap, string accessToken,
            ModeQueryParam mode = null) : base(accessToken) {
            UrlParameters.Add(beatmap);
            UrlFragments.Add(new ScoresFragment());

            QueryParameters.AddOptional(mode);
        }
    }
}
