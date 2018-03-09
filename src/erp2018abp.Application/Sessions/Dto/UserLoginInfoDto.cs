using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using erp2018abp.Authorization.Users;
using erp2018abp.Users;

namespace erp2018abp.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
