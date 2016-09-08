using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using BusinessEntity.Context;
using BusinessEntity.Inventory;
namespace Repositories
{
    public class PartialSmsRepositoryKami
    {   
        #region Insert
        public static void InsertCategory(Category category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
              
            }
        }
        public static void InsertCustomer(Customer customer)
        {
            using (var db = new InventoryContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
              
            }
        }
        public static void InsertEmployee(Employee employee)
        {
            using (var db = new InventoryContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
             
            }
        }
        public static void InsertOrder(Order order)
        {
            using (var db = new InventoryContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                
            }
        }
        public static void InsertProduct(OrderDetail orderDetail)
        {
            using (var db = new InventoryContext())
            {
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                
            }
        }
        public static void InsertOrderDetail(Product product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
             
            }
        }
        public static void InsertSupplier(Supplier supplier)
        {
            using (var db = new InventoryContext())
            {
                db.Suppliers.Add(supplier);
                db.SaveChanges();
                
            }
        }
        #endregion
        #region Update
        public static void UpdateCategory(Category category)
        {
            using (var db = new InventoryContext())
            {
                var tempCategory = db.Categories.Single(x => x.Id == category.Id);
                tempCategory.CategoryName = category.CategoryName;
                tempCategory.Description = category.Description;               
                tempCategory.Picture = category.Picture;
                db.SaveChanges();
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            using (var db = new InventoryContext())
            {
                var tempCustomer = db.Customers.Single(x => x.Id == customer.Id);
                tempCustomer.CompanyName = customer.CompanyName;
                tempCustomer.ContactName = customer.CompanyName;
                tempCustomer.ContactTitle = customer.ContactTitle;
                tempCustomer.Address = customer.Address;
                tempCustomer.City = customer.City;
                tempCustomer.Phone = customer.Phone;
                tempCustomer.Fax = customer.Fax;
                db.SaveChanges();
            }
        }
        public static void UpdateEmployee(Employee employee)
        {
            using (var db = new InventoryContext())
            {
                var tempEmployee = db.Employees.Single(x => x.Id == employee.Id);
                tempEmployee.FirstName = employee.FirstName;
                tempEmployee.LastName = employee.LastName;
                tempEmployee.Title = employee.Title;
                tempEmployee.BirthDate = employee.BirthDate;
                tempEmployee.HireDate = employee.HireDate;
                tempEmployee.Address = employee.Address;
                tempEmployee.City = employee.City;
                tempEmployee.HomePage = employee.HomePage;
                tempEmployee.Photo = employee.Photo;
                tempEmployee.PhotoPath = employee.PhotoPath;
                tempEmployee.ReportTo = employee.ReportTo;
                db.SaveChanges();
            }
        }
        public static void UpdateOrder(Order order)
        {
            using (var db = new InventoryContext())
            {
                var tempOrder = db.Orders.Single(x => x.Id == order.Id);
                tempOrder.OrderDate =order.OrderDate;
                tempOrder.CustomerId = order.CustomerId;
                tempOrder.EmployeeId = order.EmployeeId;
                tempOrder.Employee = order.Employee;
                tempOrder.Discount = order.Discount;
                tempOrder.NetTotal = order.NetTotal;
                db.SaveChanges();
            }
        }
        public static void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using (var db = new InventoryContext())
            {
                var tempOrderDetail = db.OrderDetails.Single(x => x.Id == orderDetail.Id);
                tempOrderDetail.ProductId = orderDetail.ProductId;
                tempOrderDetail.Product = orderDetail.Product;
                tempOrderDetail.UnitPrice = orderDetail.UnitPrice;
                tempOrderDetail.Quantity = orderDetail.Quantity;
                tempOrderDetail.Discount = orderDetail.Discount;
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(Product product)
        {
            using (var db = new InventoryContext())
            {
                var tempProduct = db.Products.Single(x => x.Id == product.Id);
                tempProduct.Quantity= product.Quantity;
                tempProduct.ProductName = product.ProductName;
                tempProduct.Supplier = product.Supplier;
                tempProduct.CategoryId = product.CategoryId;
                tempProduct.SupplierId = product.SupplierId;
                tempProduct.UnitPrice = product.UnitPrice;
                tempProduct.UnitsInStock = product.UnitsInStock;
                tempProduct.Discountinued = product.Discountinued;
                db.SaveChanges();
            }
        }
        public static void UpdateSupplier(Supplier supplier)
        {
            using (var db = new InventoryContext())
            {
                var tempSupplier = db.Suppliers.Single(x => x.Id == supplier.Id);
                tempSupplier.Address = supplier.Address;
                tempSupplier.CompanyName = supplier.CompanyName;
                tempSupplier.ContactName = supplier.ContactName;
                tempSupplier.ContactTitle = supplier.ContactTitle;
                tempSupplier.Fax = supplier.Fax;
                tempSupplier.Phone = supplier.Phone;
                tempSupplier.City = supplier.City;
                tempSupplier.HomePage = supplier.HomePage;
                db.SaveChanges();
            }
        }
        #endregion
        #region Delete
        public static void DeleteCategory(int categoryId)
        {

            using (var db = new InventoryContext())
            {
                var tempCategory = db.Categories.Single(x => x.Id == categoryId);

                db.Categories.Remove(tempCategory);

                db.SaveChanges();
            }
        }
        public static void DeleteCustomer(int customerId)
        {
            using (var db = new InventoryContext())
            {
                var tempCustomer = db.Customers.Single(x => x.Id == customerId);

                db.Customers.Remove(tempCustomer);

                db.SaveChanges();
            }
        }
        public static void DeleteEmployee(int employeeId)
        {
            using (var db = new InventoryContext())
            {
                var tempEmployee = db.Employees.Single(x => x.Id == employeeId);

                db.Employees.Remove(tempEmployee);

                db.SaveChanges();
            }
        }
        public static void DeleteOrder(int orderId)
        {
            using (var db = new InventoryContext())
            {
                var tempOrder = db.Orders.Single(x => x.Id == orderId);

                db.Orders.Remove(tempOrder);

                db.SaveChanges();
            }
        }
        public static void DeleteOrderDetail(int orderDetailId)
        {
            using (var db = new InventoryContext())
            {
                var tempOrderDetail = db.OrderDetails.Single(x => x.Id == orderDetailId);

                db.OrderDetails.Remove(tempOrderDetail);

                db.SaveChanges();
            }
        }
        public static void DeleteProduct(int productId)
        {
            using (var db = new InventoryContext())
            {
                var tempProduct = db.Products.Single(x => x.Id == productId);

                db.Products.Remove(tempProduct);

                db.SaveChanges();
            }
        }
        public static void DeleteSupplier(int supplierId)
        {
            using (var db = new InventoryContext())
            {
                var tempSupplier = db.Suppliers.Single(x => x.Id == supplierId);

                db.Suppliers.Remove(tempSupplier);

                db.SaveChanges();
            }
        }
        #endregion
        #region Get
        public static Category GetCategoryById(int categoryId)
        {
            var tempCategory = new Category();

            using (var db = new InventoryContext())
            {
                tempCategory = db.Categories.Single(x => x.Id == categoryId);
            }
            return tempCategory;
        }
        
        public static Customer GetCustomerById(int customerId)
        {
            var tempCustomer= new Customer();

            using (var db = new InventoryContext())
            {
                tempCustomer = db.Customers.Single(x => x.Id == customerId);
            }
            return tempCustomer;
        }
        public static Employee GetEmployeeById(int employeeId)
        {
            var tempEmployee = new Employee();

            using (var db = new InventoryContext())
            {
                tempEmployee = db.Employees.Single(x => x.Id == employeeId);
            }
            return tempEmployee;
        }
        public static OrderDetail GetOrderDetailsById(int orderDetailsId)
        {
            var tempOrderDetail = new OrderDetail();

            using (var db = new InventoryContext())
            {
                tempOrderDetail = db.OrderDetails.Single(x => x.Id == orderDetailsId);
            }
            return tempOrderDetail;
        }
        public static Product GetProductById(int productId)
        {
            var tempProduct = new Product();

            using (var db = new InventoryContext())
            {
                tempProduct =db.Products.Single(x => x.Id == productId);
            }
            return tempProduct;
        }
        public static Supplier GetSupplierById(int supplierId)
        {
            var tempSupplier = new Supplier();

            using (var db = new InventoryContext())
            {
                tempSupplier = db.Suppliers.Single(x => x.Id == supplierId);
            }
            return tempSupplier;
        }
        #endregion
        #region List
        public static List<Category> GetAllCategories()
        {
            var categoryList = new List<Category>();
            using (var db = new InventoryContext())
            {
                categoryList = db.Categories.ToList();
            }
            return categoryList;
        }
        public static List<Customer> GetAllCustomers()
        {
            var customerList = new List<Customer>();
            using (var db = new InventoryContext())
            {
                customerList = db.Customers.ToList();
            }
            return customerList;
        }
        public static List<Employee> GetAllEmployees()
        {
            var employeeList = new List<Employee>();
            using (var db = new InventoryContext())
            {
                employeeList = db.Employees.ToList();
            }
            return employeeList;
        }
        public static List<Order> GetAllOrders()
        {
            var orderList = new List<Order>();
            using (var db = new InventoryContext())
            {
                orderList = db.Orders.ToList();
            }
            return orderList;
        }
        public static List<OrderDetail> GetAllOrderDetails()
        {
            var orderDetailList = new List<OrderDetail>();
            using (var db = new InventoryContext())
            {
                orderDetailList = db.OrderDetails.ToList();
            }
            return orderDetailList;
        }
        public static List<Product> GetAllProducts()
        {
            var productList = new List<Product>();
            using (var db = new InventoryContext())
            {
                productList = db.Products.ToList();
            }
            return productList;
        }
        public static List<Supplier> GetAllSuppliers()
        {
            var supplierList = new List<Supplier>();
            using (var db = new InventoryContext())
            {
                supplierList = db.Suppliers.ToList();
            }
            return supplierList;
        }
        public static List<Order> GetAllOrdersByDate(DateTime fromDate, DateTime toDate)
        {
            var orderList = new List<Order>();
            using (var db = new InventoryContext())
            {
                orderList = db.Orders.Where(x=>Convert.ToDateTime(x.OrderDate)>= fromDate && Convert.ToDateTime(x.OrderDate)<= toDate).ToList();
            }
            return orderList;
        }
        public static List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            var list = new List<OrderDetail>();
            using (var db = new InventoryContext())
            {
                list = db.OrderDetails.Where(x => x.OrderId == orderId).ToList();
            }
            return list;
        }
        public static List<Product> GetProductByCategoryId(int categoryId)
        {
            var list = new List<Product>();
            using (var db = new InventoryContext())
            {
                list = db.Products.Where(x => x.CategoryId == categoryId).ToList();
            }
            return list;
        }
        public static List<Product> GetProductBySupplierId(int supplierId)
        {
            var list = new List<Product>();
            using (var db = new InventoryContext())
            {
                list = db.Products.Where(x => x.SupplierId == supplierId).ToList();
            }
            return list;
        }
        #endregion

    }
}