using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Models.SMS
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}