using Abp.AspNetCore.Mvc.ViewComponents;

namespace TestXia.Web.Views
{
    public abstract class TestXiaViewComponent : AbpViewComponent
    {
        protected TestXiaViewComponent()
        {
            LocalizationSourceName = TestXiaConsts.LocalizationSourceName;
        }
    }
}
