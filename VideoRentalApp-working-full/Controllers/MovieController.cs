using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalApp.Models;
using VideoRentalApp.ViewModels;

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
                new Movie{Id = 1, Name = "Harry Poter"},
                new Movie{Id = 2, Name = "The Girl with the Dragon Tattoo"},
                new Movie{Id = 3, Name = "Lord of the Rings" }
            };

            return View(movie);
        }

        public ActionResult MovieForCustomer()
        {
            var movie = new Movie() { Name = "Beautiful Mind", Id = 1 };

            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="John"},
                new Customer{Id=2, Name="Bill"},
                new Customer{Id=3, Name="Rossy"}
            };

            var viewModel = new MovieForCustomerViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

    }
}