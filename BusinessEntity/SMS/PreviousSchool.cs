using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessEntity.SMS
{
    public class PreviousSchool
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string InstituteName { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LeaveDate { get; set; }
    }
}