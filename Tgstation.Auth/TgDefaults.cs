namespace Tgstation.Auth
{
    /// <summary>
    /// Default values for the /tg/station authentication handler.
    /// </summary>
    public static class TgDefaults
    {
        /// <summary>
        /// The default scheme for /tg/station authentication.
        /// </summary>
        public const string AuthenticationScheme = "Tgstation";

        /// <summary>
        /// The default display name for /tg/station authentication.
        /// </summary>
        public const string DisplayName = "/tg/station";

        /// <summary>
        /// The default endpoint used to perform /tg/station authentication.
        /// </summary>
        /// <remarks>
        /// For details on the implementation of the /tg/station authentication, see https://tgstation13.org/phpBB/viewtopic.php?f=45&t=30155
        /// </remarks>
        public const string AuthorizationEndpoint = "https://tgstation13.org/phpBB/app.php/tgapi/oauth/auth";

        /// <summary>
        /// The OAuth endpoint used to retrieve access tokens.
        /// </summary>
        public const string TokenEndpoint = "https://tgstation13.org/phpBB/app.php/tgapi/oauth/token";

        /// <summary>
        /// The /tg/station API endpoint used to gather additional user information.
        /// </summary>
        public const string UserInformationEndpoint = "https://tgstation13.org/phpBB/app.php/tgapi/user/me";

        /// <summary>
        /// The /tg/station API endpoint used to download avatars.
        /// </summary>
        public const string UserAvatarEndpoint = "https://tgstation13.org/phpBB/download/file.php?avatar=";
    }
}