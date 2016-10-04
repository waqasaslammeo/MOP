using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.SMS
{
    public class Module
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }



    }
}