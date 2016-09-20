using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Inventory
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier{ get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discountinued { get; set; }

    }
}