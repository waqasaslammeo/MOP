using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MOP.Inventory
{
    public class Order
    {
        public int   Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int OrderDate { get; set; }
        public int NetTotal { get; set; }

        public int Discount { get; set; }
        
    }
}