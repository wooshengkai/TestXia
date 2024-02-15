using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TestXia.Web.Views
{
    public abstract class TestXiaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TestXiaRazorPage()
        {
            LocalizationSourceName = TestXiaConsts.LocalizationSourceName;
        }
    }
}
