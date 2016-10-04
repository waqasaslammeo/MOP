using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MOP.Models.Inventory;
using MOP.Models.SMS;

namespace MOP.Context
{
    public class AlphaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
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
        public DbSet<PhoneDirectory> PhoneDirectories { get; set; }
        public DbSet<PhoneDirectoryDetail> PhoneDirectoryDetails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<PreviousSchool> PreviousSchools { get; set; }
    }
}