using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using WhoseTurn.ViewModels;

namespace WhoseTurn.Controllers
{
    public class TasksController : ControllerBase
    {
        public ActionResult Index(int id)
        {
            var myTasks = Db.Tasks.Where(t => t.TurnPersonId == id).ToList();
            var otherPeople = Db.People.Where(p => p.Id != id).Include(p => p.Tasks).ToList();
            
            return View(new TasksView {MyTasks = myTasks, OtherPeople = otherPeople });
        }
    }
}