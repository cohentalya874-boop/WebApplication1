using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Bookings
    {
        //public Bookings()
        //{
        //    Payments = new HashSet<Payments>();
        //}

        public int BookingId { get; set; }
        public int? UserId { get; set; }
        public int? RoomId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public int? GuestsCount { get; set; }
        public int? TotalPrice { get; set; }
        public string BookingStatus { get; set; }
        public string CreatedAt { get; set; }
        public string Status { get; set; }
        public int? CodeHotel { get; set; }

        //public virtual Rooms Room { get; set; }
        //public virtual Users User { get; set; }
        //public virtual ICollection<Payments> Payments { get; set; }
    }
}
