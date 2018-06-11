using Abp.Authorization;
using VS.DLQ.Authorization.Roles;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
