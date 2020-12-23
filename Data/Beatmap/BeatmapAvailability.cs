using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class BeatmapAvailability {
        [JsonProperty("download_disabled")]
        public bool DownloadDisabled { get; set; }

        [JsonProperty("more_information")]
        public string? Notes { get; set; }
    }
}
