using System.Linq;
using System.Security;
using System.Web.Mvc;
using WhoseTurn.Common.Services;

namespace WhoseTurn.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleService _peopleService = new PeopleService();

        public ActionResult Index(string group)
        {
            var people = _peopleService.GetPeople(group);
            if (!people.Any()) throw new SecurityException();
            return View(people);
        }
    }
}