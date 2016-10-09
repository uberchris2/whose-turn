using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Security;
using WhoseTurn.ViewModels;

namespace WhoseTurn.Controllers
{
    public class TasksController : ControllerBase
    {
        public ActionResult Index(int id)
        {
            var person = Db.People.Find(id);
            if (person == null) throw new SecurityException();
            var myTasks = Db.Tasks.Where(t => t.TurnPersonId == id).ToList();
            var otherPeople = Db.People.Where(p => p.Id != id && p.GroupId == person.GroupId).Include(p => p.Tasks).ToList();

            return View(new TasksView {MyTasks = myTasks, OtherPeople = otherPeople });
        }

        public ActionResult Complete(int id)
        {
            var task = Db.Tasks.Include(t => t.Group.People).Single(t => t.Id == id);
            var peopleInGroup = task.Group.People;
            var fromId = task.TurnPersonId;
            var nextPerson = peopleInGroup
                .OrderBy(x => x.Id)
                .FirstOrDefault(p => p.Id > fromId) ?? peopleInGroup.First();
            task.TurnPerson = nextPerson;
            Db.SaveChanges();
            return RedirectToAction("Index", new { Id = fromId });
        }
    }
}