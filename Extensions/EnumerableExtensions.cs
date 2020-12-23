using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Extensions {
    public static class EnumerableExtensions {
        public static void AddOptional<T>(this List<T> list, T value) {
            if (value == null) return;
            list.Add(value);
        }
    }
}
