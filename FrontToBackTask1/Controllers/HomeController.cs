using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
