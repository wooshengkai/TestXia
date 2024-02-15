using Abp.Authorization;
using TestXia.Authorization.Roles;
using TestXia.Authorization.Users;

namespace TestXia.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
