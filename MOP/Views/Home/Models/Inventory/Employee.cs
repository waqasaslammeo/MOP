using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.Inventory
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string HomePage { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Note { get; set; }
        public string ReportTo { get; set; }
        public string PhotoPath { get; set; }

    }
}