using Microsoft.AspNetCore.Mvc;
using mymvcapp.Data;
using mymvcapp.Models;
using System.Threading.Tasks;

namespace mymvcapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly MongoDbContext _context;

        public AccountController(MongoDbContext context)
        {
            _context = context;
        }

        // GET: /Account/SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: /Account/SignUp
        [HttpPost]
        public async Task<IActionResult> SignUp(AccountModel model)
        {
            if (ModelState.IsValid)
            {
                // Insert the document into MongoDB
                await _context.Accounts.InsertOneAsync(model);

                // Redirect to a success page or another page after successful registration
                return RedirectToAction("Index", "Home"); // Adjust redirection as needed
            }

            // If model state is invalid, return the same view with validation errors
            return View(model);
        }



    }
}
