using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        //need to get genres from database
        // GET: Gigs
        private readonly ApplicationDbContext _context;

        public GigsController() //"ctor" + TAB for constructor snippet 
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormViewModel viewModel) //model behind the view
        {
            if (!ModelState.IsValid) //if not valid, return the create view, pass viewModel to return existing values
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);
            }
            var gig = new Gig()
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTIme(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            //convert ViewModel to a GigObject added to our context and save changes

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}