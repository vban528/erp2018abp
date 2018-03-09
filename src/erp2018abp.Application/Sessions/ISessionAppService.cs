using System.Threading.Tasks;
using Abp.Application.Services;
using erp2018abp.Sessions.Dto;

namespace erp2018abp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
