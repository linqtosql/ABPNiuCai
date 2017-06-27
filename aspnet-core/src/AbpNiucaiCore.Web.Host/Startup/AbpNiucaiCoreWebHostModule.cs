using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpNiucaiCore.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AbpNiucaiCore.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpNiucaiCoreWebCoreModule))]
    public class AbpNiucaiCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpNiucaiCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpNiucaiCoreWebHostModule).GetAssembly());
        }
    }
}
