using Abp.Authorization.Users;
using Abp.Zero.EntityFrameworkCore;
using AbpNiucaiCore.Authorization.Roles;
using AbpNiucaiCore.Authorization.Users;
using AbpNiucaiCore.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace AbpNiucaiCore.EntityFrameworkCore
{
    public class AbpNiucaiCoreDbContext : AbpZeroDbContext<Tenant, Role, User, AbpNiucaiCoreDbContext>
    {
        /* Define an IDbSet for each entity of the application */

        public AbpNiucaiCoreDbContext(DbContextOptions<AbpNiucaiCoreDbContext> options)
            : base(options)
        {
            
        }
    }
}
