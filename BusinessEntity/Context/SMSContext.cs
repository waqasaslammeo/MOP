using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web;
using BusinessEntity.SMS;
using System.Configuration;
namespace BusinessEntity.Context
{
    public class SMSContext :DbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}