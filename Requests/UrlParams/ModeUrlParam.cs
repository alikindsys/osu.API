using osu.API.Requests.Parameters.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Parameters {
    public sealed class ModeUrlParam : UrlParam {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public bool valueOnly => true;

        public ModeUrlParam(Gamemode mode) {
            Key = "mode";
            Value = $"{mode.ToString().ToLowerInvariant()}";
        }

    }
}
