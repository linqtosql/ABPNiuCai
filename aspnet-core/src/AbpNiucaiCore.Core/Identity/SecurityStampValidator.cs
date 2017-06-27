using Abp.Authorization;
using AbpNiucaiCore.Authorization.Roles;
using AbpNiucaiCore.Authorization.Users;
using AbpNiucaiCore.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace AbpNiucaiCore.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}