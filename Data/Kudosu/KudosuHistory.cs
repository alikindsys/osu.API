using Newtonsoft.Json;
using osu.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.API.Data {
    public class KudosuHistory {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("post")]
        public ModdingPost Post { get; set; }

        [JsonProperty("giver")]
        public KudosuGiver Giver { get; set; }

        public KudosuSource Source => _source;

        public KudosuAction Action => _action;

        [JsonProperty("action")]
        private string ActionInfo {
            set {
                var items = value.Split('.');

                if (items.Length > 1) {
                    Enum.TryParse(items.First().Replace("_", ""), true, out _source);
                }
                else {
                    _source = KudosuSource.Forum;
                }

                Enum.TryParse(items.Last(), true, out _action);
            }
        }

        private KudosuSource _source;
        private KudosuAction _action;
    }
}
