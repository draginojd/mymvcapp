using Microsoft.AspNetCore.Mvc;

namespace mymvcapp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
