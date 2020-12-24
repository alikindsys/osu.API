using osu.API.Data;
using osu.API.Requests.Parameters;
using osu.API.Requests.UrlFragments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Requests.Users {
    public class GetUserKudosuRequest : AuthenticatedGetRequest<List<KudosuHistory>> {
        public GetUserKudosuRequest(UserUrlParam user,string accessToken) : base(accessToken) {
            UrlParameters.Add(user);
            UrlFragments.Add(new KudosuFragment());
        }

        public GetUserKudosuRequest(ulong userId, string accessToken)
            : this (new UserUrlParam(userId), accessToken){

        }
    }
}
