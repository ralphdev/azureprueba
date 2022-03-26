using Abp.Authorization;
using cursoazuredevops.Authorization.Roles;
using cursoazuredevops.Authorization.Users;

namespace cursoazuredevops.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
