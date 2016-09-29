using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace WhoseTurn.Controllers
{
    public class TasksController : ControllerBase
    {
        public ActionResult Index()
        {
            var tasks = Db.Tasks.Include(t => t.TurnPerson);
            return View(tasks.ToList());
        }
    }
}