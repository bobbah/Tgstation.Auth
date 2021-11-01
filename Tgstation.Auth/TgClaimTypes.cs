namespace Tgstation.Auth
{
    /// <summary>
    /// Defines constants for well-known /tg/station claim types that can be assigned to a subject.
    /// </summary>
    public static class TgClaimTypes
    {
        private const string ClaimTypeNamespace = "urn:tgstation:";
        
        /// <summary>
        /// The cleaned username of the user onn the /tg/station forum.
        /// </summary>
        public const string UsernameClean = ClaimTypeNamespace + "username_clean";

        /// <summary>
        /// The name of the primary group for the user on the /tg/station forum.
        /// </summary>
        public const string PrimaryGroup = ClaimTypeNamespace + "primary_group";

        /// <summary>
        /// The ID of the primary group for the user on the /tg/station forum.
        /// </summary>
        public const string PrimaryGroupId = ClaimTypeNamespace + "primary_group_id";

        /// <summary>
        /// The numeric type of user on the /tg/station forum.
        /// </summary>
        public const string UserType = ClaimTypeNamespace + "user_type";

        /// <summary>
        /// The unix timestamp at which the user registered with the /tg/station forum.
        /// </summary>
        public const string Registered = ClaimTypeNamespace + "registered";

        /// <summary>
        /// The unix timestamp at which the user last visited the /tg/station forum.
        /// </summary>
        public const string LastVisit = ClaimTypeNamespace + "last_visit";

        /// <summary>
        /// The user's rank on the /tg/station forum.
        /// </summary>
        public const string Rank = ClaimTypeNamespace + "rank";

        /// <summary>
        /// The number of posts the user has on the /tg/station forum.
        /// </summary>
        public const string Posts = ClaimTypeNamespace + "posts";

        /// <summary>
        /// The user's timezone on the /tg/station forum.
        /// </summary>
        public const string Timezone = ClaimTypeNamespace + "timezone";

        /// <summary>
        /// The user's avatar filename on the /tg/station forum.
        /// </summary>
        public const string Avatar = ClaimTypeNamespace + "avatar";

        /// <summary>
        /// A link to the user's avatar on the /tg/station forum. See <see cref="Avatar"/>.
        /// </summary>
        public const string AvatarUrl = ClaimTypeNamespace + "avatar_url";

        /// <summary>
        /// The BYOND key of the user on the /tg/station forum.
        /// </summary>
        public const string ByondKey = ClaimTypeNamespace + "byond_key";

        /// <summary>
        /// The BYOND canonical key of the user on the /tg/station forum.
        /// </summary>
        public const string ByondCKey = ClaimTypeNamespace + "byond_ckey";

        /// <summary>
        /// The linked GitHub username of the user on the /tg/station forum.
        /// </summary>
        public const string GithubUsername = ClaimTypeNamespace + "github_username";

        /// <summary>
        /// The linked Reddit username of the user on the /tg/station forum.
        /// </summary>
        public const string RedditUsername = ClaimTypeNamespace + "reddit_username";
    }
}