using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Hotels
    {
        //public Hotels()
        //{
        //    Reviews = new HashSet<Reviews>();
        //    Rooms = new HashSet<Rooms>();
        //}

        public int IdHotel { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int? Stars { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<Reviews> Reviews { get; set; }
        //public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
