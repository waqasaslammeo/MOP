﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.Inventory
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}