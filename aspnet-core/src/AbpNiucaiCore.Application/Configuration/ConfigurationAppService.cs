using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpNiucaiCore.Configuration.Dto;

namespace AbpNiucaiCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpNiucaiCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
