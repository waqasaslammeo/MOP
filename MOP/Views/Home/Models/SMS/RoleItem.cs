using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.SMS
{
    public class RoleItem
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int ItemId { get; set; }
        public virtual SystemItem Item { get; set; }
    }
}