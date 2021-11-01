using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace Tgstation.Auth
{
    /// <summary>
    /// Configuration options for <see cref="TgHandler"/>.
    /// </summary>
    public class TgOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new <see cref="TgOptions"/>
        /// </summary>
        public TgOptions()
        {
            // Note this is is the path that will be reserved for finishing the oauth handshake
            CallbackPath = new PathString("/signin-tgstation");
            
            // Paths for the /tg/station oauth API
            AuthorizationEndpoint = TgDefaults.AuthorizationEndpoint;
            TokenEndpoint = TgDefaults.TokenEndpoint;
            UserInformationEndpoint = TgDefaults.UserInformationEndpoint;

            // For available scopes see: https://tgstation13.org/phpBB/viewtopic.php?f=45&t=30155
            Scope.Add("user.linked_accounts");

            // Map all claim types, note that if not present they will just no-op and not appear in claims
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "user_id");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "username");
            ClaimActions.MapJsonKey(TgClaimTypes.UsernameClean, "username_clean");
            ClaimActions.MapJsonKey(TgClaimTypes.UserType, "user_type");
            ClaimActions.MapJsonKey(TgClaimTypes.Registered, "registered");
            ClaimActions.MapJsonKey(TgClaimTypes.LastVisit, "lastvisit");
            ClaimActions.MapJsonKey(TgClaimTypes.Rank, "rank");
            ClaimActions.MapJsonKey(TgClaimTypes.Posts, "posts");
            ClaimActions.MapJsonKey(TgClaimTypes.Timezone, "timezone");
            ClaimActions.MapJsonKey(TgClaimTypes.Avatar, "avatar");
            ClaimActions.MapCustomJson(TgClaimTypes.AvatarUrl,
                user => user.TryGetProperty("avatar", out var avatar)
                    ? TgDefaults.UserAvatarEndpoint + avatar.GetString()
                    : null);
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(TgClaimTypes.ByondKey, "byond_key");
            ClaimActions.MapJsonKey(TgClaimTypes.ByondCKey, "byond_ckey");
            ClaimActions.MapJsonKey(TgClaimTypes.GithubUsername, "github_username");
            ClaimActions.MapJsonKey(TgClaimTypes.RedditUsername, "reddit_username");
            ClaimActions.Add(new TgRoleClaimAction());
        }
    }
}