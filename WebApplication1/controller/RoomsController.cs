using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Rooms> GetAllRooms()
        {
            return db.Rooms.ToList();

        }
        [HttpPost]
        public void AddRooms(Rooms Room)
        {
            db.Rooms.Add(Room);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateRooms(Rooms Room)
        {
            db.Rooms.Update(Room);
            db.SaveChanges();
        }
    }
}
