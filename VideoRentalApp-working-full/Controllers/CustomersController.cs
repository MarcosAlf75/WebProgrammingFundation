using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalApp;
using VideoRentalApp.Models;
using System.Data.Entity;

namespace VideoRentalApp.Controllers
{
    public class CustomersController : Controller
    {
        //GET: Customers
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.Membership).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.Id == id);
           // var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        /***************** Manipulate Data Without Database ***************/
        /*
        public ActionResult Index()
        {

            List<Customer> customer = new List<Customer>()
            {
                new Customer{Id = 1, Name = "John Hamilton"},
                new Customer{Id = 2, Name = "Bill Moore"},
                new Customer{Id = 3, Name = "Rossy Taylor" }
            };

            ViewBag.CustomerCount = customer.Count;
            ViewData["customers"] = customer;
            return View();
            //return View(customer);
        }
        public ActionResult Edit(int id)
        {
            return Content("Customers/Edit/id==" + id + ")");
        }
        public ActionResult Sort(int? id, string sortBy)
        {
            if (!id.HasValue)
                id = 0;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content("id == " + id + ", SortBy ==" + sortBy);
        }
        */
    }
}