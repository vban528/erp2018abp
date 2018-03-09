using Abp.Application.Services;
using Abp.Application.Services.Dto;
using erp2018abp.MultiTenancy.Dto;

namespace erp2018abp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
