using System.Linq;
using System.Web.Mvc;

namespace WhoseTurn.Controllers
{
    public class PeopleController : ControllerBase
    {
        public ActionResult Index(string group)
        {
            var people = Db.People.Where(p => p.Group.Name == group);
            return View(people.ToList());
        }
    }
}