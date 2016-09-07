using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web;
using BusinessEntity.SMS;
using BusinessEntity.Context;
using System.Configuration;
namespace BusinessEntity.Context
{
    public class SMSContext :DbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<SystemItem> SystemItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleItem> RoleItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}