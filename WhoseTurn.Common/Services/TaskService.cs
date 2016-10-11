using System.Data.Entity;
using System.Linq;
using System.Security;
using WhoseTurn.Common.ViewModels;

namespace WhoseTurn.Common.Services
{
    public class TaskService
    {
        protected readonly DbModel Db = new DbModel();

        public TasksView GetTasks(int id)
        {
            var person = Db.People.Find(id);
            if (person == null) throw new SecurityException();
            var myTasks = Db.Tasks.Where(t => t.TurnPersonId == id).ToList();
            var otherPeople = Db.People.Where(p => p.Id != id && p.GroupId == person.GroupId).Include(p => p.Tasks).ToList();
            var tasksView = new TasksView {MyTasks = myTasks, OtherPeople = otherPeople};
            return tasksView;
        }

        public int CompleteTask(int id)
        {
            var task = Db.Tasks.Include(t => t.Group.People).Single(t => t.Id == id);
            var fromId = task.TurnPersonId;
            var peopleInGroup = task.Group.People.OrderBy(x => x.Id);
            var nextPerson = peopleInGroup.FirstOrDefault(p => p.Id > fromId) ?? peopleInGroup.First();
            task.TurnPerson = nextPerson;
            Db.SaveChanges();
            return fromId;
        }
    }
}