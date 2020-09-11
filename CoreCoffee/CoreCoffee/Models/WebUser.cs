﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCoffee.Models
{
    public class WebUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public int ID { get; set; }

        public static List<WebUser> Users = new List<WebUser>();
    }
}
