using osu.API.Data.Auth.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Client.Auth {
    public record ClientCredentialsGrant (ulong Id, string Secret);
    public record AuthorizationCodeGrant (ulong Id, string RedirectUri, string State, params Scope[] Scopes);
}
