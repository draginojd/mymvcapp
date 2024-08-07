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

        private readonly ApplicationDBContext _context;


        public RegistrationController(ApplicationDBContext db)
        {
            _context = db;
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
                _context.Add(user);
                _context.SaveChanges();
                ViewBag.message = $"The user: {user.Username}, is successfully registered";
                return View();
            }
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.UserRegistration
                    .FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
                ViewBag.Message = $"The user: {user.Username}, is successfully registered";
                if (existingUser != null)
                {
                    // Ideally, set up a session or authentication cookie here.
                    // For simplicity, just redirect to a welcome page.
                    return RedirectToAction("Welcome");
                }

                ModelState.AddModelError("", "Invalid username or password");
            }

            return View(user);
        }

        public IActionResult Welcome ()
        {
            return View();
        }

    }
}
