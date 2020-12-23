using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data.Enums {

    public enum ScoreGrade {
        [Description("None")]
        N,

        [Description("F")]
        F,

        [Description("D")]
        D,

        [Description("C")]
        C,

        [Description("B")]
        B,

        [Description("A")]
        A,

        [Description("S")]
        S,

        [Description("S+")]
        SH,

        [Description("SS")]
        X,

        [Description("SS+")]
        XH,
    }
}
