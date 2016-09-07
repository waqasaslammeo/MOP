using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessEntity.SMS
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string TagLink { get; set; }
        public string ShortDescription { get; set; }
        public string DetailDescription { get; set; }
        public string FounderName { get; set; }
        public DateTime FoundedOn { get; set; }
        public string PhoneNumber { get; set; }
    }
}