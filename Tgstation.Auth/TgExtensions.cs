using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Tgstation.Auth
{
    /// <summary>
    /// Extension methods to configure /tg/station OAuth authentication.
    /// </summary>
    public static class TgExtensions
    {
        /// <summary>
        /// Adds /tg/station OAuth-based authentication to <see cref="AuthenticationBuilder"/> using hte default scheme.
        /// The default scheme is specified by <see cref="TgDefaults.AuthenticationScheme"/>.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/>.</param>
        /// <returns>A reference to <paramref name="builder"/> after the operation has completed.</returns>
        public static AuthenticationBuilder AddTgstation(this AuthenticationBuilder builder)
            => builder.AddTgstation(TgDefaults.AuthenticationScheme, _ => { });

        /// <summary>
        /// Adds /tg/station OAuth-based authentication to <see cref="AuthenticationBuilder"/> using hte default scheme.
        /// The default scheme is specified by <see cref="TgDefaults.AuthenticationScheme"/>.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="configureOptions">A delegate to configure <see cref="TgOptions"/>.</param>
        /// <returns>A reference to <paramref name="builder"/> after the operation has completed.</returns>
        public static AuthenticationBuilder AddTgstation(this AuthenticationBuilder builder,
            Action<TgOptions> configureOptions)
            => builder.AddTgstation(TgDefaults.AuthenticationScheme, configureOptions);

        /// <summary>
        /// Adds /tg/station OAuth-based authentication to <see cref="AuthenticationBuilder"/> using hte default scheme.
        /// The default scheme is specified by <see cref="TgDefaults.AuthenticationScheme"/>.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="authenticationScheme">The authentication scheme.</param>
        /// <param name="configureOptions">A delegate to configure <see cref="TgOptions"/>.</param>
        /// <returns>A reference to <paramref name="builder"/> after the operation has completed.</returns>
        public static AuthenticationBuilder AddTgstation(this AuthenticationBuilder builder,
            string authenticationScheme, Action<TgOptions> configureOptions)
            => builder.AddTgstation(authenticationScheme, TgDefaults.DisplayName, configureOptions);

        /// <summary>
        /// Adds /tg/station OAuth-based authentication to <see cref="AuthenticationBuilder"/> using hte default scheme.
        /// The default scheme is specified by <see cref="TgDefaults.AuthenticationScheme"/>.
        /// </summary>
        /// <param name="builder">The <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="authenticationScheme">The authentication scheme.</param>
        /// <param name="displayName">A display name for the authentication handler.</param>
        /// <param name="configureOptions">A delegate to configure <see cref="TgOptions"/>.</param>
        /// <returns>A reference to <paramref name="builder"/> after the operation has completed.</returns>
        public static AuthenticationBuilder AddTgstation(this AuthenticationBuilder builder,
            string authenticationScheme, string displayName, Action<TgOptions> configureOptions)
            => builder.AddOAuth<TgOptions, TgHandler>(authenticationScheme, displayName, configureOptions);
    }
}