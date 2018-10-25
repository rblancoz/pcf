using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PersonalCashFlow.Controllers
{
    public abstract class PersonalCashFlowControllerBase: AbpController
    {
        protected PersonalCashFlowControllerBase()
        {
            LocalizationSourceName = PersonalCashFlowConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
