using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data.Enums {
    public enum Gamemode {
        [Description("osu!")]
        osu = 0,

        [Description("osu!taiko")]
        Taiko = 1,

        [Description("osu!catch")]
        Fruits = 2,

        [Description("osu!mania")]
        Mania = 3
    }
}
