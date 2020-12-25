using osu.API.Data;
using osu.API.Requests.UrlParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Beatmap {
    public class GetBeatmapsetRequest : AuthenticatedGetRequest<Beatmapset> {
        public GetBeatmapsetRequest(BeatmapsetUrlParam beatmapset, string accessToken) : base(accessToken) {
            UrlParameters.Add(beatmapset);
        }

        public GetBeatmapsetRequest(ulong beatmapsetId, string accessToken)
            : this(new BeatmapsetUrlParam(beatmapsetId), accessToken) {

        }
    }
}
