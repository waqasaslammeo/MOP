using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessEntity.SMS
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}