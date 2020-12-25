using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class IdsQueryParam : QueryParam {
        public string Key => "ids[]";

        public string Value { get; internal set; }
        public IdsQueryParam (ulong id) {
            Value = id.ToString();
        }
    }
}
