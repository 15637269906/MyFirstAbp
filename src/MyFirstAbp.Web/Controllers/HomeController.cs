using Microsoft.AspNetCore.Mvc;

namespace MyFirstAbp.Web.Controllers
{
    public class HomeController : MyFirstAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}