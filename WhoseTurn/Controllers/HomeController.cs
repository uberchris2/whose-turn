using System.Web.Mvc;

namespace WhoseTurn.Controllers
{
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}