using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;

namespace mymvcapp.Controllers
{
    public class RegistrationController : Controller

    {

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        private readonly ApplicationUser _db;

        public RegistrationController(ApplicationUser db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Add(user);
                _db.SaveChanges();
                ViewBag.message = $"The user: {user.Username}, is successfully registered";
                return View();
            }
            return View(user);
        }



    }
}
