using ConcertJam.Models;
using ConcertJam.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ConcertJam.Controllers
{
    public class ShowsController : Controller
    {
        // GET: Shows
        private ApplicationDbContext _context;


        public ShowsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new ShowFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}