using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class BeatmapScores {
        [JsonProperty("scores")]
        public List<Score> Scores { get; set; }
    }
}
