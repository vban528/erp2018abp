using Abp.Authorization;
using erp2018abp.Authorization.Roles;
using erp2018abp.Authorization.Users;

namespace erp2018abp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
