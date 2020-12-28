using osu.API.Requests.QueryParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Beatmap {
    public class LookupBeatmapRequest : AuthenticatedGetRequest<Data.Beatmap> {
        public LookupBeatmapRequest(FilenameQueryParam file, string accessToken) : base(accessToken) {
            BaseUrl += "/beatmaps/lookup";
            QueryParameters.Add(file);
        }
        public LookupBeatmapRequest(ChecksumQueryParam md5Checksum, string accessToken) : base(accessToken) {
            BaseUrl += "/beatmaps/lookup";
            QueryParameters.Add(md5Checksum);
        }
        public LookupBeatmapRequest(IdQueryParam id, string accessToken) : base(accessToken) {
            BaseUrl += "/beatmaps/lookup";
            QueryParameters.Add(id);
        }
    }
}
