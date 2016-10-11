using System.Web.Mvc;
using WhoseTurn.Common.Services;

namespace WhoseTurn.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskService _taskService = new TaskService();

        public ActionResult Index(int id)
        {
            var tasksView = _taskService.GetTasks(id);
            return View(tasksView);
        }

        public ActionResult Complete(int id)
        {
            var fromId = _taskService.CompleteTask(id);
            return RedirectToAction("Index", new { Id = fromId });
        }
    }
}