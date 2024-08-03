using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;

namespace mymvcapp.Controllers
{
    public class CustomerController : Controller
    {

        public static List<Customer>customers = new List<Customer>()
        {
            new Customer() { Id = 1, Address = "BulevardAvenue 118", Amount = 14000, City="Stockholm", Country="Sweden", Name="John Macafee", Phone="+0721134963", PostalCode="14942", Region="Stockholms län"},
            new Customer() { Id = 2, Address = "Windoford Street 118", Amount = 8000, City="Göteborg", Country="Sweden", Name="Andres Sten", Phone="+0721134963", PostalCode="23352", Region="Göteborgs län"},
            new Customer() { Id = 3, Address = "BulevardAvenue 118", Amount = 100, City="Malmö", Country="Sweden", Name="Bilal Muhammad", Phone="+0721134963", PostalCode="31942", Region="Skåne län"},
            new Customer() { Id = 4, Address = "BulevardAvenue 118", Amount = 26000, City="Västerås", Country="Sweden", Name="Gunilla Petterson", Phone="+0721134963", PostalCode="47942", Region="Norrbottens län"}

        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer managment system - Armin";
            ViewBag.CustomerCount = customers.Count(); //because Customer is a list object we can use the count method.
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {

            return View(); 
        }

        public IActionResult Message() 
        { 
            return View(); 
        }

    }
}
