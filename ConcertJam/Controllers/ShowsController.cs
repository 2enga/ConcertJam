using ConcertJam.Models;
using ConcertJam.ViewModels;
using Microsoft.AspNet.Identity;
using System;
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
            var artistID = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == artistID);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);
            var show = new Show
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venue = viewModel.Venue
            };

            _context.Shows.Add(show);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}