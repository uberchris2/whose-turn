using System.Linq;
using System.Web.Mvc;

namespace WhoseTurn.Controllers
{
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            var people = Db.People;
            return View(people.ToList());
        }
    }
}