using System.Collections.Generic;
using System.Linq;
using erp2018abp.Roles.Dto;
using erp2018abp.Users.Dto;

namespace erp2018abp.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.DisplayName);
        }
    }
}