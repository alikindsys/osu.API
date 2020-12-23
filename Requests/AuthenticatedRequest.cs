using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests {
    public abstract class AuthenticatedRequest<T> : BaseRequest<T> {
        internal string AccessToken { get; }
        public AuthenticatedRequest(string accessToken) {
            AccessToken = accessToken;
        }
    }
}
