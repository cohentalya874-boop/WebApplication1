using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Payments
    {
        public int PaymentsId { get; set; }
        public int? BookingId { get; set; }
        public double? Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }

        //public virtual Bookings Booking { get; set; }
    }
}
