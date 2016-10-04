using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOP.SMS
{
    public class StudentEnrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}