using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class OffsetQueryParam : QueryParam {
        public string Key { get; private set; }

        public string Value { get; private set; }

        public OffsetQueryParam(int offset) {
            Key = "offset";
            Value = offset.ToString();
        }
    }
}
