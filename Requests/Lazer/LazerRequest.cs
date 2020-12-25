using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Lazer {
    /// <summary>
    /// A Lazer request is a request intended for use by the osu!lazer client which isn't currently avaliable
    /// for use by the public.
    /// For that reasoning, they are dummy requests that do nothing.
    /// </summary>
    public abstract class LazerRequest<T> : BaseRequest<T> {
    }
}
