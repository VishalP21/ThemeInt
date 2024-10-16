using Microsoft.AspNetCore.Mvc;

namespace ThemeInt.Controllers
{
    public class DashbordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
