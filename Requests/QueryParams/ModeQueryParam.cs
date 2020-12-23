using osu.API.Data.Enums;
using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class ModeQueryParam : QueryParam {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public ModeQueryParam(Gamemode mode) {
            Key = "mode";
            Value = $"{mode.ToString().ToLowerInvariant()}";
        }
    }
}
