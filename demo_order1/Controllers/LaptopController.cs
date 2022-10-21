using demo_order1.Data;
using Microsoft.AspNetCore.Mvc;


namespace demo_order1.Controllers
{
    public class LaptopController : Controller
    {
        protected ApplicationDbContext context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
