using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Payments> GetAllPayments()
        {
            return db.Payments.ToList();

        }
        [HttpPost]
        public void AddPayments(Payments Payment)
        {
            db.Payments.Add(Payment);
            db.SaveChanges();
        }

    }
}
