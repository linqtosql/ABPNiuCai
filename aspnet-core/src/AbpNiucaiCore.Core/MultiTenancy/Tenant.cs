using Abp.MultiTenancy;
using AbpNiucaiCore.Authorization.Users;

namespace AbpNiucaiCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}