using System.Web.Mvc;
using VisitSite.Extensions.Filters;

namespace VisitSite.Controllers
{
    [HomeControllerFilter]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

    }
}
