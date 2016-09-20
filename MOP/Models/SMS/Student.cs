using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.SMS
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentRollNo { get; set; }
        public string FatherName { get; set; }
        public int PreviousSchoolId { get; set; }
        public virtual PreviousSchool PreviousSchool { get; set; }
        public int StudentEnrollmentId { get; set; }
        public virtual StudentEnrollment StudentEnrollment { get; set; }
        public string FatherCNIC { get; set; }
        public string PassportNo { get; set; }
        public DateTime VisaStartDate { get; set; }
        public DateTime VisaExpiryDate { get; set; }
        public string GuardianName { get; set; }
        public string GuardianCNIC { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string EmailAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
    }
}