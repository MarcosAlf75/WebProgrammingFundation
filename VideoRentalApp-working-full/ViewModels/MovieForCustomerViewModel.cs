using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalApp.Models;

namespace VideoRentalApp.ViewModels
{
    public class MovieForCustomerViewModel
    {
        public Movie Movie {get; set;}
        public List<Customer> Customers { get; set; } 

    }
}