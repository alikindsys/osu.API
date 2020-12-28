using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.UrlParams {
    public class BeatmapUrlParam : UrlParam {
        public string Key => "beatmaps";

        public string Value { get; private set; }

        public bool valueOnly => false;

        public BeatmapUrlParam(ulong beatmapId) {
            Value = beatmapId.ToString();
        }
    }
}
