using System.Web.Mvc;

namespace ConcertJam.Controllers
{
    public class ShowsController : Controller
    {
        // GET: Shows
        public ActionResult Create()
        {
            return View();
        }
    }
}