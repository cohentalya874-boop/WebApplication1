using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Hotels> GetAllHotels()
        {
            return db.Hotels.ToList();

        }
        [HttpPost]
        public void AddHotels(Hotels hotel)
        {
            db.Hotels.Add(hotel);
            db.SaveChanges();
        }

    }
}