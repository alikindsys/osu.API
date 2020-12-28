using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class IdQueryParam : QueryParam {
        public string Key => "id";

        public string Value { get; private set; }

        public IdQueryParam(ulong id){
            Value = id.ToString();
        }
    }
}
