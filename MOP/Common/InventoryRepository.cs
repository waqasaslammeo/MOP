using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MOP.Context;
using MOP.Inventory;

namespace MOP.Common
{
    public static class InventoryRepository
    {
        #region Insert
        public static void InsertCategory(Category category)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertCategory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertCustomer(Customer customer)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertCustomer " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertEmployee(Employee employee)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertEmployee " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertOrder(Order order)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertOrder " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertOrderDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertProduct(Product product)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertProduct " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertSupplier(Supplier supplier)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSupplier " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion

        #region Update
        public static void UpdateCategory(Category category)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCategory = db.Categories.Single(x => x.Id == category.Id);
                    tempCategory.CategoryName = category.CategoryName;
                    tempCategory.Description = category.Description;
                    tempCategory.Picture = category.Picture;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateCategory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var db = new AlphaContext())
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
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateCustomer " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateEmployee(Employee employee)
        {
            try
            {
                using (var db = new AlphaContext())
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
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateEmployee " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateOrder(Order order)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempOrder = db.Orders.Single(x => x.Id == order.Id);
                    tempOrder.OrderDate = order.OrderDate;
                    tempOrder.CustomerId = order.CustomerId;
                    tempOrder.EmployeeId = order.EmployeeId;
                    tempOrder.Employee = order.Employee;
                    tempOrder.Discount = order.Discount;
                    tempOrder.NetTotal = order.NetTotal;
                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateOrder " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var db = new AlphaContext())
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
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateOrderDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempProduct = db.Products.Single(x => x.Id == product.Id);
                    tempProduct.Quantity = product.Quantity;
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
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateProduct " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSupplier(Supplier supplier)
        {
            try
            {
                using (var db = new AlphaContext())
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
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateSupplier " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion

        #region Delete
        public static void DeleteCategory(int categoryId)
        {

            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCategory = db.Categories.Single(x => x.Id == categoryId);
                    db.Categories.Remove(tempCategory);
                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteCategory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteCustomer(int customerId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCustomer = db.Customers.Single(x => x.Id == customerId);

                    db.Customers.Remove(tempCustomer);

                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteCustomer " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteEmployee(int employeeId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempEmployee = db.Employees.Single(x => x.Id == employeeId);

                    db.Employees.Remove(tempEmployee);

                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteEmployee " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteOrder(int orderId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempOrder = db.Orders.Single(x => x.Id == orderId);
                    db.Orders.Remove(tempOrder);
                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteOrder " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteOrderDetail(int orderDetailId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempOrderDetail = db.OrderDetails.Single(x => x.Id == orderDetailId);
                    db.OrderDetails.Remove(tempOrderDetail);
                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteOrderDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteProduct(int productId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempProduct = db.Products.Single(x => x.Id == productId);

                    db.Products.Remove(tempProduct);

                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteProduct " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSupplier(int supplierId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSupplier = db.Suppliers.Single(x => x.Id == supplierId);

                    db.Suppliers.Remove(tempSupplier);

                    db.SaveChanges();
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSupplier " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion

        #region Get
        public static Category GetCategoryById(int categoryId)
        {
            var tempCategory = new Category();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempCategory = db.Categories.Single(x => x.Id == categoryId);
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetCategoryById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempCategory;
        }
        public static Customer GetCustomerById(int customerId)
        {
            var tempCustomer = new Customer();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempCustomer = db.Customers.Single(x => x.Id == customerId);
                }

            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetCustomerById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempCustomer;
        }
        public static Employee GetEmployeeById(int employeeId)
        {
            var tempEmployee = new Employee();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempEmployee = db.Employees.Single(x => x.Id == employeeId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetEmployeeById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempEmployee;
        }
        public static OrderDetail GetOrderDetailsById(int orderDetailsId)
        {
            var tempOrderDetail = new OrderDetail();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempOrderDetail = db.OrderDetails.Single(x => x.Id == orderDetailsId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetOrderDetailsById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempOrderDetail;
        }
        public static Product GetProductById(int productId)
        {
            var tempProduct = new Product();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempProduct = db.Products.Single(x => x.Id == productId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetProductById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempProduct;
        }
        public static Supplier GetSupplierById(int supplierId)
        {
            var tempSupplier = new Supplier();

            try
            {
                using (var db = new AlphaContext())
                {
                    tempSupplier = db.Suppliers.Single(x => x.Id == supplierId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSupplierById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return tempSupplier;
        }
        #endregion

        #region List
        public static List<Category> GetAllCategories()
        {
            var categoryList = new List<Category>();
            try
            {
                using (var db = new AlphaContext())
                {
                    categoryList = db.Categories.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllCategories " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return categoryList;
        }
        public static List<Customer> GetAllCustomers()
        {
            var customerList = new List<Customer>();
            try
            {
                using (var db = new AlphaContext())
                {
                    customerList = db.Customers.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllCustomers " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return customerList;
        }
        public static List<Employee> GetAllEmployees()
        {
            var employeeList = new List<Employee>();
            try
            {
                using (var db = new AlphaContext())
                {
                    employeeList = db.Employees.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllEmployees " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return employeeList;
        }
        public static List<Order> GetAllOrders()
        {
            var orderList = new List<Order>();
            try
            {
                using (var db = new AlphaContext())
                {
                    orderList = db.Orders.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllOrders " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return orderList;
        }
        public static List<OrderDetail> GetAllOrderDetails()
        {
            var orderDetailList = new List<OrderDetail>();
            try
            {
                using (var db = new AlphaContext())
                {
                    orderDetailList = db.OrderDetails.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllOrderDetails " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return orderDetailList;
        }
        public static List<Product> GetAllProducts()
        {
            var productList = new List<Product>();
            try
            {
                using (var db = new AlphaContext())
                {
                    productList = db.Products.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllProducts " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return productList;
        }
        public static List<Supplier> GetAllSuppliers()
        {
            var supplierList = new List<Supplier>();
            try
            {
                using (var db = new AlphaContext())
                {
                    supplierList = db.Suppliers.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSuppliers " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return supplierList;
        }
        public static List<Order> GetAllOrdersByDate(DateTime fromDate, DateTime toDate)
        {
            var orderList = new List<Order>();
            try
            {
                using (var db = new AlphaContext())
                {
                    orderList = db.Orders.Where(x => Convert.ToDateTime(x.OrderDate) >= fromDate && Convert.ToDateTime(x.OrderDate) <= toDate).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllOrdersByDate " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return orderList;
        }
        public static List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            var list = new List<OrderDetail>();
            try
            {
                using (var db = new AlphaContext())
                {
                    list = db.OrderDetails.Where(x => x.OrderId == orderId).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetOrderDetailsByOrderId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return list;
        }
        public static List<Product> GetProductByCategoryId(int categoryId)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new AlphaContext())
                {
                    list = db.Products.Where(x => x.CategoryId == categoryId).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetProductByCategoryId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return list;
        }
        public static List<Product> GetProductBySupplierId(int supplierId)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new AlphaContext())
                {
                    list = db.Products.Where(x => x.SupplierId == supplierId).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetProductBySupplierId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return list;
        }
        #endregion
    }
}