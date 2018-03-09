using System.Threading.Tasks;
using Abp.Application.Services;
using erp2018abp.Authorization.Accounts.Dto;

namespace erp2018abp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
