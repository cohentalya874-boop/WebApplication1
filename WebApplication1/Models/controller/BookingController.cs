using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Models.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Bookings>GetAllBookings()
        {
            return db.Bookings.ToList();

        }
        [HttpGet("ByBooking")]
        public List<Bookings> GetAllBookingByHotel(int codeHotel)
        {
            return db.Bookings.Where(x => x.CodeHotel == codeHotel).ToList();
        }
        [HttpPost]
        public void AddBookings(Bookings codehotel)
        {
            db.Bookings.Add(codehotel);
            db.SaveChanges();
        }


    }
}
