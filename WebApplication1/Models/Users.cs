using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Users
    {
        //public Users()
        //{
        //    Bookings = new HashSet<Bookings>();
        //    Reviews = new HashSet<Reviews>();
        //}

        public int NumUsers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public bool? Status { get; set; }
        public string Id { get; set; }

        //public virtual ICollection<Bookings> Bookings { get; set; }
        //public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
