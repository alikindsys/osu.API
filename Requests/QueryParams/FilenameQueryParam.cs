using osu.API.Requests.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.QueryParams {
    public class FilenameQueryParam : QueryParam {
        public string Key => "filename";

        public string Value { get; private set; }
        public FilenameQueryParam (string fileName) {
            Value = fileName;
        }
    }
}
