using System.Threading.Tasks;
using Abp.Application.Services;
using AbpNiucaiCore.Sessions.Dto;

namespace AbpNiucaiCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
