using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class ChecksumQueryParam : QueryParam {
        public string Key => "checksum";

        public string Value { get; private set; }
        public ChecksumQueryParam(string md5Checksum) {
            Value = md5Checksum;
        }

    }
}
