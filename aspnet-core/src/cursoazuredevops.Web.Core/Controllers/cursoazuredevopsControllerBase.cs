using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace cursoazuredevops.Controllers
{
    public abstract class cursoazuredevopsControllerBase: AbpController
    {
        protected cursoazuredevopsControllerBase()
        {
            LocalizationSourceName = cursoazuredevopsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
