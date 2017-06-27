using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using AbpNiucaiCore.Configuration;
using AbpNiucaiCore.EntityFrameworkCore;
using AbpNiucaiCore.Migrator.DependencyInjection;

namespace AbpNiucaiCore.Migrator
{
    [DependsOn(typeof(AbpNiucaiCoreEntityFrameworkModule))]
    public class AbpNiucaiCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpNiucaiCoreMigratorModule(AbpNiucaiCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AbpNiucaiCoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpNiucaiCoreConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpNiucaiCoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}