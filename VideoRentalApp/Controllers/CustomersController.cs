using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalApp;
using VideoRentalApp.Models;

namespace VideoRentalApp.Controllers
{
    public class CustomersController : Controller
    {
        //GET: Customers

        public ActionResult Index()
        {
            List<Customer> customer = new List<Customer>()
            {
                new Customer{Id = 1, Name = "John Hamilton"},
                new Customer{Id = 2, Name = "Bill Moore"},
                new Customer{Id = 3, Name = "Rossy Taylor" }
            };

            return View(customer);
        }

    }
}