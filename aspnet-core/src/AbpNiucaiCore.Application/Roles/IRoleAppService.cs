using System.Threading.Tasks;
using Abp.Application.Services;
using AbpNiucaiCore.Roles.Dto;

namespace AbpNiucaiCore.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
