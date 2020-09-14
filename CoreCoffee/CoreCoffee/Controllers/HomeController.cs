using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreCoffee.Models;

namespace CoreCoffee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public static bool ValidatePassword(string pass)
        {
            foreach (char let in pass)
            {
                if (let == '1' || let == '2' || let == '3' || let == '4' || let == '5' || let == '6' || let == '7' || let == '8' || let == '9' || let == '0')
                {
                    return true;
                }
            }
            return false;
        }

        [HttpPost]
        public IActionResult NewUser(string firstName, string lastName, string eMail, string phone, string pass1, string pass2)
        {
            bool match = false;
            bool validPass = true;
            ViewBag.Match = match;
            ViewBag.Name = $"{firstName} {lastName}";
            ViewBag.eMail = eMail;
            match = pass1.Equals(pass2);

            validPass = ValidatePassword(pass1);

            if (!validPass)
            {
                ViewBag.passStatus = "The password did not contain a number";
                return View("Register");
            }

            if (!match)
            {
                ViewBag.matchStatus = "The Passwords did not match";
                return View("Register");
                //return RedirectToAction("Register", "Home");
                //return Content($"The passwords do not match");
            }

            WebUser newUser = new WebUser
            {
                Name = $"{firstName} {lastName}",
                Email = eMail,
                Phone = phone,
                Pass = pass1,
                ID = WebUser.Users.Count
            };

            WebUser.Users.Add(newUser);

            return View(newUser);
        }

        public IActionResult WebOrder(string id)
        {
            int numid = int.Parse(id);

            var viewModel = new Order
            {
                Person = WebUser.Users[numid],
                ID = Order.Orders.Count,
                Stuff = new List<Item>(),
                Delivery = false,
                Time = System.DateTime.Now
            };

            Order.Orders.Add(viewModel);

            return View("AddItem", viewModel);
        }

        public IActionResult PassNoMatch()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public IActionResult AddItem(string DSelect, string Size, int orderNumber)
        {
            var viewModel = new Item
            {
                Size = Size,
                Drink = DSelect
            };

            Order.Orders[orderNumber].Stuff.Add(viewModel);

            return View("Another", Order.Orders[orderNumber]);
        }

        public IActionResult Another(int orderNumber)
        {
            //int numid = int.Parse(id);
            return View("AddItem", Order.Orders[orderNumber]);
        }

        public IActionResult Delivery(int orderNumber)
        {
            return View(Order.Orders[orderNumber]);
        }

        public IActionResult Checkout(string Delivery, int orderNumber)
        {
            if (Delivery == "Delivery")
            {
                Order.Orders[orderNumber].Delivery = true;
            }
            else
            {
                Order.Orders[orderNumber].Delivery = false;
            }
            Order.Orders[orderNumber].Time = System.DateTime.Now;


            return View(Order.Orders[orderNumber]);
        }

        public IActionResult Goodbye()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
