using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using erp2018abp.Roles.Dto;
using erp2018abp.Users.Dto;

namespace erp2018abp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}