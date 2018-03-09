using Abp.AutoMapper;
using erp2018abp.Sessions.Dto;

namespace erp2018abp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}