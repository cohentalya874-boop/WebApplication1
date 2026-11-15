using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Users> GetAllUsers()
        {
            return db.Users.ToList();

        }
        [HttpPost]
        public void AddUsers(Users User)
        {
            db.Users.Add(User);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateUsers(Users User)
        {
            db.Users.Update(User);
            db.SaveChanges();
        }
    }
}
