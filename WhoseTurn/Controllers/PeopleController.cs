using System.Linq;
using System.Security;
using System.Web.Mvc;

namespace WhoseTurn.Controllers
{
    public class PeopleController : ControllerBase
    {
        public ActionResult Index(string group)
        {
            var people = Db.People.Where(p => p.Group.Name == group).ToList();
            if (!people.Any()) throw new SecurityException();
            return View(people.ToList());
        }
    }
}