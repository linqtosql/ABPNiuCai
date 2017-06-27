using AbpNiucaiCore.Configuration;
using AbpNiucaiCore.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace AbpNiucaiCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpNiucaiCoreDbContextFactory : IDbContextFactory<AbpNiucaiCoreDbContext>
    {
        public AbpNiucaiCoreDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AbpNiucaiCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpNiucaiCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpNiucaiCoreConsts.ConnectionStringName));
            
            return new AbpNiucaiCoreDbContext(builder.Options);
        }
    }
}