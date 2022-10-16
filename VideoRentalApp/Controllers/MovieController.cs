using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalApp.Models;
using System.Data.Entity;

namespace VideoRentalApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.MovieT).ToList();
            return View(movies);
        }
        public ActionResult DetailsMovie(int id)
        {
            var movies = _context.Movies.Include(c => c.MovieT).SingleOrDefault(c => c.Id == id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

    }
}