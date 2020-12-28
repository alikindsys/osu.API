using osu.API.Data;
using osu.API.Requests.QueryParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Beatmap {
    public class LookupBeatmapsetRequest : AuthenticatedGetRequest<Beatmapset> {
        public LookupBeatmapsetRequest(BeatmapIdQueryParam beatmap, string accessToken) : base(accessToken) {
            BaseUrl += "/beatmapsets/lookup";
            QueryParameters.Add(beatmap);
        }

        public LookupBeatmapsetRequest(ulong beatmapId, string accessToken)
            : this(new BeatmapIdQueryParam(beatmapId), accessToken) {

        }
    }
}
