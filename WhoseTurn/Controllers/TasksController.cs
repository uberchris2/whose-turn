using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace WhoseTurn.Controllers
{
    public class TasksController : Controller
    {
        private readonly DbModel _db = new DbModel();

        public ActionResult Index()
        {
            var tasks = _db.Tasks.Include(t => t.TurnPerson);
            return View(tasks.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}