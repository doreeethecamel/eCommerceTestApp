using Microsoft.AspNetCore.Mvc;


namespace eCommerceTest.Controllers
{
    public class CategoryController : Controller
    {

        //private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}
