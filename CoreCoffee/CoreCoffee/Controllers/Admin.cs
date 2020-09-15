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
                   
            return RedirectPreserveMethod("InventoryControl");
        }
        
        public IActionResult EditItem(long pid)
        {
            Products prod = Products.Read(pid);
            return View(prod);
        }

        public IActionResult SaveItem(long pid, string name, string category, decimal price, string description)
        {
            Products prod = Products.Read(pid);
            prod.Product_Name = name;
            prod.Product_Category = category;
            prod.Product_Price = price;
            prod.Product_Description = description;
            prod.Save();
            ViewBag.Message = "The item has been updated";

            return RedirectPreserveMethod("InventoryControl");
            //return Content($"pid {pid} name {name}, category {category}, price{price}, desc {description}");
        }

        public IActionResult ConfirmRemove(long pid)
        {
            Products prod = Products.Read(pid);
            return View(prod);
        }

        public IActionResult Remove(long pid)
        {
            Products.Delete(pid);
            return RedirectPreserveMethod("InventoryControl");
        }
    }
}
