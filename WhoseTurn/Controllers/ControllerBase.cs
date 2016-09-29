using System.Web.Mvc;

namespace WhoseTurn.Controllers
{
    public class ControllerBase : Controller
    {
        protected readonly DbModel Db = new DbModel();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}