using System.Collections.Generic;
using erp2018abp.Roles.Dto;

namespace erp2018abp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}