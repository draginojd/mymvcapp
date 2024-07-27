using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;
using System.ComponentModel.DataAnnotations;

namespace mymvcapp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            var account = new AccountModel() 
            {Id=1,Email="example@gmail.com", FirstName="First name", LastName="Last name" , Password="Password123"}; 

            return View(account);
        }

        [HttpPost]
        public IActionResult SignUp(AccountModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form data here (e.g., save to the database)

                // Redirect to a confirmation page or back to the same page
                return RedirectToAction("Index", "Home");
            }

            // If validation fails, return the same view with error messages
            return View(model);
        }
    }
}

