using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.UrlParams {
    public class RecentActivityUrlParam : UrlParam {
        public string Key { get; private set; }

        public string Value { get; private set; }
        public bool valueOnly => true;
        public RecentActivityUrlParam() {
            Value = "recent_activity";
        }

    }
}
