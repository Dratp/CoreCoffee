﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCoffee.Models
{
    public class Order
    {
        public int ID { get; set; }
        public WebUser Person { get; set; }
        public List<Item> Stuff { get; set; }
        public bool Delivery { get; set; }
        public DateTime Time { get; set; }

        public static List<Order> Orders = new List<Order>();

    }
}
