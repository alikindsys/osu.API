using osu.API.Data;
using osu.API.Requests.UrlParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Beatmap {
    public class GetBeatmapRequest : AuthenticatedGetRequest<Data.Beatmap> {
        public GetBeatmapRequest(BeatmapUrlParam beatmap ,string accessToken) : base(accessToken) {
            UrlParameters.Add(beatmap);
        }

        public GetBeatmapRequest(ulong beatmapId, string accessToken)
            : this(new BeatmapUrlParam(beatmapId), accessToken) {

        }
    }
}
