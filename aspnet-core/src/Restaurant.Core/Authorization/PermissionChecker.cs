using Abp.Authorization;
using Restaurant.Authorization.Roles;
using Restaurant.Authorization.Users;

namespace Restaurant.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
