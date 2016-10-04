using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.SMS
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}