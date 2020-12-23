using Newtonsoft.Json;
using System;

namespace osu.API.Data {
    public class User {
        [JsonProperty("avatar_url")] public string AvatarUrl { get; set; }
        [JsonProperty("country_code")] public string CountryCode { get; set; }
        [JsonProperty("default_group")] public string DefaultGroup { get; set; }
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("username")] public string Username { get; set; }
        [JsonProperty("is_active")] public bool IsActive { get; set; }
        [JsonProperty("is_bot")] public bool IsBot { get; set; }
        [JsonProperty("is_online")] public bool IsOnline { get; set; }
        [JsonProperty("is_supporter")] public bool IsSupporter { get; set; }
        [JsonProperty("last_visit")] public DateTime? LastVisit { get; set; }
        [JsonProperty("pm_friends_only")] public bool PmFriendOnly { get; set; }
        [JsonProperty("cover_url")] public string CoverUrl { get; set; }
        [JsonProperty("discord")] public string Discord { get; set; }
        [JsonProperty("has_supported")] public bool HasSupported { get; set; }
        [JsonProperty("interests")] public string Interests { get; set; }
        [JsonProperty("join_date")] public DateTime JoinDate { get; set; }
        [JsonProperty("kudosu")] public UserKudosu Kudosu { get; set; }
        [JsonProperty("lastfm")] public string LastFm { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("max_blocks")] public int MaxBlocks { get; set; }
        [JsonProperty("max_friends")] public int MaxFriends { get; set; }
        [JsonProperty("playmode")] public string PlayMode { get; set; }
        [JsonProperty("playstyle")] public string[] PlayStyle { get; set; }
        [JsonProperty("post_count")] public int PostCount { get; set; }
        [JsonProperty("profile_order")] public string[] ProfileOrder { get; set; }
        [JsonProperty("skype")] public string Skype { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("website")] public string Website { get; set; }
        [JsonProperty("country")] public UserCountry Country { get; set; }
        [JsonProperty("cover")] public UserCover Cover { get; set; }
        [JsonProperty("badges")] public UserBadge[] Badges { get; set; }
        [JsonProperty("favourite_beatmapset_count")] public int FavoriteBeatmapSetCount { get; set; }
        [JsonProperty("follower_count")] public int FollowerCount { get; set; }
        [JsonProperty("loved_beatmapset_count")] public int LovedBeatmapSetCount { get; set; }
        [JsonProperty("monthly_playcounts")] public UserPlayCount[] MonthlyPlayCount { get; set; }
        [JsonProperty("page")] public UserPage Page { get; set; }
        [JsonProperty("previous_usernames")] public string[] PreviousUsernames { get; set; }
        [JsonProperty("ranked_and_approved_beatmapset_count")] public int RankedAndApprovedBeatmapSetCount { get; set; }
        [JsonProperty("replays_watched_counts")] public UserWatchedCount[] ReplaysWatchedCounts { get; set; }
        [JsonProperty("scores_first_count")] public int ScoresFirstCount { get; set; }
        [JsonProperty("statistics")] public UserStatistics Statistics { get; set; }
        [JsonProperty("support_level")] public int SupportLevel { get; set; }
        [JsonProperty("unranked_beatmapset_count")] public int UnrankedBeatmapSetCount { get; set; }
        [JsonProperty("user_achievements")] public UserAchievement[] UserAchievements { get; set; }
        [JsonProperty("rankHistory")] public UserRankHistory RankHistory { get; set; }
    }
}
