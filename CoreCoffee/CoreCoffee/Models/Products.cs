using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CoreCoffee.Models
{
    [Table("CoffeeProduct")]
    public class Products
    {
        [Key]
        public long Product_id { get; set; }

        public string Product_Category { get; set; } 
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public decimal Product_Price { get; set; }

        public static List<Products> Read()
        {
            List<Products> prods;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                prods = db.GetAll<Products>().ToList();
            }
            return prods;
        }

        public static Products Create(string _category, string _name, decimal _price, string _description)
        {
            Products prod = new Products()
            {
                Product_Category = _category,
                Product_Name = _name,
                Product_Price = _price,
                Product_Description = _description
            };
            long id;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                id = db.Insert<Products>(prod);
            }
            prod.Product_id = id;

            return prod;
        }

        public static Products Read(long _id)
        {
            Products prod;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                prod = db.Get<Products>(_id);
            }
            return prod;
        }

        public static void Delete(long _id)
        {
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                db.Delete(new Products() { Product_id = _id });
            }
        }

        public void Save()
        {
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=CoreCoffee;user id=csharp;password=abc123"))
            {
                db.Update(this);
            }
        }

    }
}
