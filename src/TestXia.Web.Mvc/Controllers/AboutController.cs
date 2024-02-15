using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestXia.Controllers;

namespace TestXia.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TestXiaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
