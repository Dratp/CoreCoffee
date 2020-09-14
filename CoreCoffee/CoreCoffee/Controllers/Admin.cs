using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using CoreCoffee.Models;

namespace CoreCoffee.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InventoryControl()
        {
            List<Products> prods = Products.Read();
            return View(prods);
        }

        public IActionResult CreateItem()
        {
            return View();
        }

        public IActionResult AddItem(string category, string name, decimal price, string description)
        {
            //return Content($"category = {category} name = {name} price = {price} description = {description}");
            Products.Create(category, name, price, description);
            ViewBag.Message = "Your item has been added";
                   
            return RedirectToAction("InventoryControl");
        }



    }
}
