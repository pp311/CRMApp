using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace Lab2.Application.Commons.Permissions;

public class PermissionPolicyProvider : DefaultAuthorizationPolicyProvider
{
    private const string PolicyPrefix = "Permission";
    public PermissionPolicyProvider(
        IOptions<AuthorizationOptions> options) : base(options) { }

    public override async Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
    {
        if (!policyName.StartsWith(PolicyPrefix, StringComparison.OrdinalIgnoreCase))
            return await base.GetPolicyAsync(policyName);
        
        return new AuthorizationPolicyBuilder()
            .AddRequirements(new PermissionRequirement(policyName)).Build();
    }
}