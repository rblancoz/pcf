using Abp.Authorization;
using PersonalCashFlow.Authorization.Roles;
using PersonalCashFlow.Authorization.Users;

namespace PersonalCashFlow.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
