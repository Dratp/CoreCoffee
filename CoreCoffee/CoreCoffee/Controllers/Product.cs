using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using CoreCoffee.Models;

namespace CoreCoffee.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Products> prods;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                prods = db.Query<Products>("select * from [CoffeeProduct]").AsList<Products>();
            }

            return View(prods);
        }

        public IActionResult Drink(int drinkid)
        {
            Products prod;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                prod = db.QuerySingle<Products>($"select * from [CoffeeProduct] where Product_id={drinkid}");
            }

            return View(prod);
        }



    }
}
