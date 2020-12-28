using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class BeatmapIdQueryParam : QueryParam {
        public string Key => "beatmap_id";

        public string Value { get; internal set; }

        public BeatmapIdQueryParam(ulong beatmapId) {
            Value = beatmapId.ToString();
        }
    }
}
