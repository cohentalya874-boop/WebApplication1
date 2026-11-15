using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Reviews
    {
        public int ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? HotelId { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Status { get; set; }

        //public virtual Hotels Hotel { get; set; }
        //public virtual Users User { get; set; }
    }
}
