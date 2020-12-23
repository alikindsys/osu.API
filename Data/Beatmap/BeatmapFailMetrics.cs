using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class BeatmapFailMetrics {
        [JsonProperty("fail")]
        public IEnumerable<uint> Fail { get; set; }

        [JsonProperty("exit")]
        public IEnumerable<uint> Quit { get; set; }
    }
}
