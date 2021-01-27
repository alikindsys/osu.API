using osu.API.Client.Auth;
using osu.API.Data.Enums;
using osu.API.Requests;
using osu.API.Requests.Beatmap;
using osu.API.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Client {
    public class osuClient : IDisposable {
        internal string token;
        internal ClientCredentialsGrant clientGrant;
        internal HttpClient http;
        public osuClient(ClientCredentialsGrant Grant) {
            clientGrant = Grant;
            http = new();
        }
        public async Task ConnectAsync() {
            if (clientGrant != null) {
                var responce = await Authentication.OAuthClientCredentialsAsync(clientGrant, http);
                token = responce.Token;
            }
        }

        //
        // Beatmap
        //
        public Task<Data.Beatmap> GetBeatmapRequest(ulong beatmapId)
            => new GetBeatmapRequest(beatmapId, token).GetAsync(http);

        public Task<Data.BeatmapScores> GetBeatmapScoresRequest(ulong beatmapId)
            => new GetBeatmapScoresRequest(new(beatmapId), token).GetAsync(http);

        public Task<Data.BeatmapScores> GetBeatmapScoresRequest(ulong beatmapId, Gamemode mode)
            => new GetBeatmapScoresRequest(new(beatmapId), token, new(mode)).GetAsync(http);

        //
        // User
        //
        public Task<Data.User> GetOwnDataRequest()
            => new GetOwnDataRequest(token).GetAsync(http);

        public Task<Data.User> GetUserRequest(ulong userId)
            => new GetUserRequest(userId, token).GetAsync(http);

        public Task<Data.User> GetUserRequest(ulong userId, Gamemode mode)
            => new GetUserRequest(userId, mode, token).GetAsync(http);

        public Task<List<Data.Score>> GetUserScoresRequest(ulong userId, ScoreType type)
            => new GetUserScoresRequest(userId, type, token).GetAsync(http);

        public Task<List<Data.Score>> GetUserScoresRequest(ulong userId, ScoreType type, bool includeFails = false, Gamemode mode = Gamemode.osu, int limit = 5, int offset = 0)
            => new GetUserScoresRequest(userId,type,token,includeFails,mode,limit,offset).GetAsync(http);


        public void Dispose() {
            http.Dispose();
        }
    }
}
