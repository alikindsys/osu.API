using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.UrlParams {
    public class BeatmapsetUrlParam : UrlParam {
        public string Key => "beatmapsets";

        public string Value { get; private set; }

        public bool valueOnly => false;

        public BeatmapsetUrlParam(ulong beatmapsetId) {
            Value = beatmapsetId.ToString();
        }
    }
}
