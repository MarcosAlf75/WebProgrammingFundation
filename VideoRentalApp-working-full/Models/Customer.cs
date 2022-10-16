using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace VideoRentalApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool isSubscribed { get; set; }
        public Membership Membership { get; set; }
        public int MembershipId { get; set; }
    }
}