using osu.API.Data;
using osu.API.Requests.QueryParams;
using osu.API.Requests.UrlFragments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Lazer {
    public class GetUsersRequest : LazerRequest<List<User>> {
        public GetUsersRequest() {
            UrlFragments.Add(new UsersFragment());
        }

        public GetUsersRequest(params IdsQueryParam[] ids) {
            UrlFragments.Add(new UsersFragment());
            foreach(var id in ids) {
                QueryParameters.Add(id);
            }
        }
    }
}
