using ConcertJam.Models;
using ConcertJam.ViewModels;
using Microsoft.AspNet.Identity;
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

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ShowFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(ShowFormViewModel viewModel)
        {


            var show = new Show
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Shows.Add(show);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}