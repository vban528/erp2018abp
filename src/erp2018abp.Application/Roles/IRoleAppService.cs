using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using erp2018abp.Roles.Dto;

namespace erp2018abp.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
