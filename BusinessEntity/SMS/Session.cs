using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessEntity.SMS
{
    public class Session
    {
        public int Id { get; set; }
        public String SessionName { get; set; }
        public bool IsCurrent { get; set; }

    }
}