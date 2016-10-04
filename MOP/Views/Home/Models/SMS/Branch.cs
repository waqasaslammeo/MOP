using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.SMS
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

        //Usama Ikram Model Change 9-22-2016
        public string Address { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
    }
}