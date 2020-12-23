using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class LimitQueryParam : QueryParam {
        public string Key { get; private set; }

        public string Value { get; private set; }

        public LimitQueryParam(int limit) {
            Key = "limit";
            Value = limit.ToString();
        }
    }
}
