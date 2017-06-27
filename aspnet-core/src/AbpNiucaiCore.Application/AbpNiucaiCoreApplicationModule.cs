using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpNiucaiCore.Authorization;

namespace AbpNiucaiCore
{
    [DependsOn(
        typeof(AbpNiucaiCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpNiucaiCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpNiucaiCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpNiucaiCoreApplicationModule).GetAssembly());
        }
    }
}