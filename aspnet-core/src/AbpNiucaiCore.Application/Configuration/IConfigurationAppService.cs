using System.Threading.Tasks;
using AbpNiucaiCore.Configuration.Dto;

namespace AbpNiucaiCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}