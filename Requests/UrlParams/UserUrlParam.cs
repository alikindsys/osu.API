using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Parameters {
    public sealed class UserUrlParam : UrlParam {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public bool valueOnly => false;

        public UserUrlParam(ulong id) {
            Key = "users";
            Value = $"{id}";
        }
    }
}
