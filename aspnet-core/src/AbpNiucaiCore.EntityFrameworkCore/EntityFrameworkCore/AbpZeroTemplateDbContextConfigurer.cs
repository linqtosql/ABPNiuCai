using Microsoft.EntityFrameworkCore;

namespace AbpNiucaiCore.EntityFrameworkCore
{
    public static class AbpNiucaiCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpNiucaiCoreDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }
    }
}