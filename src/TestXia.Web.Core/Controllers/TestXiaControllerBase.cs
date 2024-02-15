using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestXia.Controllers
{
    public abstract class TestXiaControllerBase: AbpController
    {
        protected TestXiaControllerBase()
        {
            LocalizationSourceName = TestXiaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
