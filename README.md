# Tgstation.Auth

A non-generic OAuth provider to be used with ASP.NET Core 5.0 and the /tg/station forums.

Example usage:
```csharp
services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = TgDefaults.AuthenticationScheme;
    })
    .AddCookie()
    .AddTgstation(options =>
    {
        var tgAuthSection = Configuration.GetSection("Authentication:Tgstation");
        options.ClientId = tgAuthSection["ClientId"];
        options.ClientSecret = tgAuthSection["ClientSecret"];
        options.Scope.Add("user.details");
        options.Scope.Add("user.groups");
    });
```

Note that you will need a client ID and secret as provided by MSO, as there is currently no self-serve portal for application creation. See [this post](https://tgstation13.org/phpBB/viewtopic.php?f=45&t=30155) for more details on the /tg/station OAuth implementation.