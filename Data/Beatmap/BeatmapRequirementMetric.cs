using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class BeatmapRequirementMetric {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("required")]
        public int Required { get; set; }
    }
}
