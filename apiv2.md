# Current compatibility list for osu! api (V2)

- [ ] User
- - [x] [GetOwnData](https://osu.ppy.sh/docs/#get-own-data) `5b5b7b7`
- - [x] [GetUserKudosu](https://osu.ppy.sh/docs/#get-user-kudosu) `be47d6f`
- - [x] [GetUserScores](https://osu.ppy.sh/docs/#get-user-scores) `864a1f7`
- - [x] [GetUserBeatmaps](https://osu.ppy.sh/docs/#get-user-beatmaps) `2cbe91a`
- - [x] [GetUserRecentActivity](https://osu.ppy.sh/docs/#get-user-recent-activity) `25d014d`
- - [x] [GetUser](https://osu.ppy.sh/docs/#get-user) `34b6016`
- - [ ] [GetUsers](https://osu.ppy.sh/docs/#get-users)

- [ ] Ranking
- - [ ] [GetRanking](https://osu.ppy.sh/docs/#get-ranking)
- - [ ] [GetSpotlights](https://osu.ppy.sh/docs/#get-spotlights)

- [ ] Chat
- - [ ] [CreateNewPM](https://osu.ppy.sh/docs/#create-new-pm)
- - [ ] [GetUpdates](https://osu.ppy.sh/docs/#get-updates)
- - [ ] [GetChannelMessages](https://osu.ppy.sh/docs/#get-channel-messages)
- - [ ] [SendMessageToChannel](https://osu.ppy.sh/docs/#send-message-to-channel)
- - [ ] [JoinChannel](https://osu.ppy.sh/docs/#join-channel)
- - [ ] [LeaveChannel](https://osu.ppy.sh/docs/#leave-channel)
- - [ ] [MarkChannelAsRead](https://osu.ppy.sh/docs/#mark-channel-as-read)
- - [ ] [GetChannelList](https://osu.ppy.sh/docs/#get-channel-list)
- - [ ] [CreateChannel](https://osu.ppy.sh/docs/#create-channel)

- [ ] Comments
- - [ ] [GetComments](https://osu.ppy.sh/docs/#get-comments)
- - [ ] [PostANewComment](https://osu.ppy.sh/docs/#post-a-new-comment)
- - [ ] [GetAComment](https://osu.ppy.sh/docs/#get-a-comment)
- - [ ] [EditComment](https://osu.ppy.sh/docs/#edit-comment)
- - [ ] [DeleteComment](https://osu.ppy.sh/docs/#delete-comment)
- - [ ] [AddCommentVote](https://osu.ppy.sh/docs/#add-comment-vote)
- - [ ] [RemoveCommentVote](https://osu.ppy.sh/docs/#remove-comment-vote)

- [ ] Multiplayer
- - [ ] [GetUserHighScore](https://osu.ppy.sh/docs/#get-user-high-score)
- - [ ] [GetScores](https://osu.ppy.sh/docs/#get-scores)
- - [ ] [GetAScore](https://osu.ppy.sh/docs/#get-a-score)

- [ ] Notification
- - [ ] [GetNotifications](https://osu.ppy.sh/docs/#get-notifications)
- - [ ] [MarkNotificationsAsRead](https://osu.ppy.sh/docs/#mark-notifications-as-read)

- [ ] Auth
- - [ ] [RevokeCurrentToken](https://osu.ppy.sh/docs/#revoke-current-token)

List of Uncategorized Requests
---
Once a request is categorized and researched implementation on it can begin.

- /beatmapsets/events
- /beatmapsets/{beatmapset}/favourites
- /chat/presence
- /changelog/{stream}/{build}
- /changelog
- /changelog/{changelog}
- /rooms/{mode?}
- [PUT] /rooms/{room}/users/{user}
- [DELETE] /rooms/{room}/users/{user}
- /rooms/{room}/leaderboard
- /rooms/{room}/playlist/{playlist}/scores
- [PUT] /rooms/{room}/playlist/{playlist}/scores/{score}
- [PATCH] /rooms/{room}/playlist/{playlist}/scores/{score}
- /reports
- /rooms
- /rooms/{room}
- /seasonal-backgrounds
- /scores/{mode}/{score}/download
- /scores/{mode}/{score}
- /beatmaps/{id}/scores
- /beatmaps/lookup
- /beatmaps/{beatmap}
- /beatmapsets/search/{filters?}
- /beatmapsets/lookup
- /beatmapsets/{beatmapset}/download
- /beatmapsets/{beatmapset}
- /friends
- /me/download-quota-check
- /news
- /news/{news}
