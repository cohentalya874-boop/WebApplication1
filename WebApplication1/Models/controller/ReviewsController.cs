using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Models.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Reviews> GetAllReviews()
        {
            return db.Reviews.ToList();

        }
        [HttpPost]
        public void AddReviews(Reviews Review)
        {
            db.Reviews.Add(Review);
            db.SaveChanges();
        }

    }
}
