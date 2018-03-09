using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using erp2018abp.MultiTenancy;

namespace erp2018abp.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}