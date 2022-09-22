using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalApp.Models;

namespace VideoRentalApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        //public ActionResult Index()
        //{
        //    var movie = new Movie()
        //    {
        //        Title = "Lord of the Rings I"
        //    };
        //    return View(movie);
        //}

        public ActionResult Index()
        {
            List<Movie> movie = new List<Movie>()
            {
                new Movie{Id = 1, Title = "Harry Poter"},
                new Movie{Id = 2, Title = "The Girl with the Dragon Tattoo"},
                new Movie{Id = 3, Title = "Lord of the Rings" }
            };

            return View(movie);
        }
    }
}