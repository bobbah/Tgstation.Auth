using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Tgstation.Auth.Groups;

namespace Tgstation.Auth;

/// <summary>
/// A ClaimAction for converting all /tg/station OAuth groups into role claims
/// </summary>
public class TgRoleClaimAction() : ClaimAction(ClaimTypes.Role, ClaimValueTypes.String)
{
    public override void Run(JsonElement userData, ClaimsIdentity identity, string issuer)
    {
        if (userData.ValueKind == JsonValueKind.Null || !userData.TryGetProperty("groups", out var groupData))
            return;

        var groups = groupData.EnumerateArray().Select(x => new TgGroup(x)).ToList();
        foreach (var group in groups)
        {
            identity.AddClaim(new Claim(ClaimType, group.Name, ValueType, issuer));
        }

        // Add primary group info if available
        if (!userData.TryGetProperty("primary_group", out var primary) ||
            !primary.TryGetInt32(out var primaryGroup))
            return;
            
        identity.AddClaim(new Claim(TgClaimTypes.PrimaryGroupId, primaryGroup.ToString()));
        var actualGroup = groups.FirstOrDefault(x => x.Id == primaryGroup);
        if (actualGroup != null)
            identity.AddClaim(new Claim(TgClaimTypes.PrimaryGroup, actualGroup.Name));
    }
}