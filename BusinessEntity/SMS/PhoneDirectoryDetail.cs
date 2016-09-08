using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessEntity.SMS
{
    public class PhoneDirectoryDetail
    {
        public int Id { get; set; }
        public int PhoneDirectoryId { get; set; }
        public virtual PhoneDirectory PhoneDirectory { get; set; }
        public string PhoneNumber { get; set; }
    }
}