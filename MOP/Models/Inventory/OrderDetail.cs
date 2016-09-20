using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Inventory
{
    public class OrderDetail
    {

        public int  Id { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

    }
}