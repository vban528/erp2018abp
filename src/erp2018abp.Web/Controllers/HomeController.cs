using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace erp2018abp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : erp2018abpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}