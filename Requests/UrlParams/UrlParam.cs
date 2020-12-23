using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Parameters {
    public interface UrlParam {
        public string Key { get; }
        public string Value { get; }
        public bool valueOnly { get; }
    }
}
