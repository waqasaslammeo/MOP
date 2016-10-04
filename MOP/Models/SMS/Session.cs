using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.SMS
{
    public class Session
    {
        public int Id { get; set; }
        public string SessionName { get; set; }
        public bool IsCurrent { get; set; }

    }
}