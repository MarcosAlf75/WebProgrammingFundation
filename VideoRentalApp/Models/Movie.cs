using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoRentalApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DayAdded { get; set; }
        public int NumberInStock { get; set; }
        public MovieType MovieT { get; set; }
        //public int MovieTypes_Id { get; set; }
    }
}