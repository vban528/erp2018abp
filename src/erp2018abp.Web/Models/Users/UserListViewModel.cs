using System.Collections.Generic;
using erp2018abp.Roles.Dto;
using erp2018abp.Users.Dto;

namespace erp2018abp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}