using osu.API.Data.Enums;
using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Parameters {
    public class BeatmapsetTypeUrlParam : UrlParam {
        public string Key { get; private set; }

        public string Value { get; private set; }

        public bool valueOnly => false;

        public BeatmapsetTypeUrlParam(UserBeatmapsetStatus type) {
            Key = "beatmapsets";
            Value = type switch {
                UserBeatmapsetStatus.RankedAndApproved => "ranked_and_approved",
                _ => type.ToString().ToLowerInvariant()
            };
        }
    }
}
