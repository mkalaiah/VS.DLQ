using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VS.DLQ.Controllers
{
    public abstract class DLQControllerBase: AbpController
    {
        protected DLQControllerBase()
        {
            LocalizationSourceName = DLQConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
