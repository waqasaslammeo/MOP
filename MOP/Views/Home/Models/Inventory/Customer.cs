﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.Inventory
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }

    }
}