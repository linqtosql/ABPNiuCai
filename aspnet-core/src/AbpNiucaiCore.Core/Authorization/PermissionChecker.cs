using Abp.Authorization;
using AbpNiucaiCore.Authorization.Roles;
using AbpNiucaiCore.Authorization.Users;

namespace AbpNiucaiCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
