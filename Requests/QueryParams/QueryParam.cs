using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Parameters {
    public interface QueryParam {
        string Key { get; }
        string Value { get; }
    }
}
