using System.Web.Http;
using System.Web.Http.Description;
using WhoseTurn.Common.Services;
using WhoseTurn.Common.ViewModels;

namespace WhoseTurn.Api.Controllers
{
    public class TasksController : ApiController
    {
        private readonly TaskService _taskService = new TaskService();

        [ResponseType(typeof(TasksView))]
        public IHttpActionResult GetTasks(int id)
        {
            return Ok(_taskService.GetTasks(id));
        }

        [Route("api/Tasks/Complete/{id}")]
        public IHttpActionResult Complete(int id)
        {
            _taskService.CompleteTask(id);
            return Ok();
        }
    }
}