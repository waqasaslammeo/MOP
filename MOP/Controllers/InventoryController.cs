using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Common;
using MOP.Models.Inventory;

namespace MOP.Controllers
{
    public class InventoryController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        #region Category

        public void CommonCategory()
        {
            var categoryList = InventoryRepository.GetAllCategories();
            ViewBag.CategoryList = categoryList;
        }

        [HttpGet]
        public ActionResult Category(int id = 0)
        {
            var category = InventoryRepository.GetCategoryById(id);
            ViewBag.Category = category;
            CommonCategory();
            return View();
        }

        [HttpPost]
        public ActionResult Category(Category category)
        {
            if (category.Id > 0)
            {
                InventoryRepository.UpdateCategory(category);
            }
            else
            {
                InventoryRepository.InsertCategory(category);
            }

            CommonCategory();

            return RedirectToAction("index", "Inventory", new { p = "Category" });
        }
        public ActionResult DeleteCategory(int categoryId)
        {
            InventoryRepository.DeleteCategory(categoryId);
            CommonCategory();
            return RedirectToAction("index", "Inventory", new { p= "Category"});
        }
        #endregion

        #region Customer
        public void CommonCustomer()
        {
            var customerList = InventoryRepository.GetAllCustomers();
            ViewBag.CustomerList = customerList;

        }
        [HttpGet]
        public ActionResult Customer(int id=0)
        {
            if (id > 0)
            {
                var customer=InventoryRepository.GetCustomerById(id);
                ViewBag.Customer = customer;
            }
            CommonCustomer();
            return View();
        }
        [HttpPost]
        public ActionResult Customer(Customer customer)
        {
            if (customer.Id > 0)
            {
                InventoryRepository.UpdateCustomer(customer);
            }
            else
            {
                InventoryRepository.InsertCustomer(customer);
            }
            CommonCustomer();
            return PartialView("Customer");
        }
        public ActionResult CustomerDelete(int customerId)
        {
            InventoryRepository.DeleteCustomer(customerId);
            CommonCustomer();
            return RedirectToAction("index", "Inventory", new { p = "Customer" });
        }
        #endregion

        #region Employee

        public void CommonEmployee()
        {
            var employeeList = InventoryRepository.GetAllSuppliers();
            ViewBag.EmployeeList = employeeList;
        }
        [HttpGet]
        public ActionResult Employee(int id)
        {
            if (id > 0)
            {
                var employee = InventoryRepository.GetEmployeeById(id);
                ViewBag.Employee = employee;
            }
            CommonEmployee();
            return View();
        }
        [HttpPost]
        public ActionResult Employee(Employee employee)
        {
            if (employee.Id > 0)
            {
                InventoryRepository.UpdateEmployee(employee);
            }
            else
            {
                InventoryRepository.InsertEmployee(employee);
            }
            CommonEmployee();
            return RedirectToAction("index", "Inventory", new { p = "Employee" });
        }
        [HttpPost]
        public ActionResult EmployeeDelete(int employeeId)
        {
            InventoryRepository.DeleteEmployee(employeeId);
            CommonEmployee();
            return RedirectToAction("index", "Inventory", new { p = "Employee" });
        }
        #endregion
        #region Order
        public void CommonOrder()
        {
            var orderList = InventoryRepository.GetAllOrders();
            ViewBag.OrderList = orderList;
        }
        [HttpGet]
        public ActionResult Order(int id =0)
        {
            if (id > 0)
            {
                var order = InventoryRepository.GetOrderById(id);
                ViewBag.Order = order;
            }
            CommonOrder();
            return View();
        }
        [HttpPost]
        public ActionResult Order(Order order)
        {
            if (order.Id > 0)
            {
                InventoryRepository.UpdateOrder(order);
            }
            else
            {
                InventoryRepository.InsertOrder(order);
            }
            CommonOrder();
            return RedirectToAction("index", "Inventory", new { p = "Order" });
        }
        public ActionResult OrderDelete(int orderId)
        {
            InventoryRepository.DeleteOrder(orderId);
            CommonOrder();
            return RedirectToAction("index", "Inventory", new { p = "Order" });
        }
        #endregion
        #region OrderDetails
        public void CommonOrderDetail()
        {
            var orderDetailList = InventoryRepository.GetAllOrderDetails();
            ViewBag.OrderDetailList = orderDetailList;
        }
        [HttpGet]
        public ActionResult OrderDetail(int id = 0)
        {
            var orderDetail = InventoryRepository.GetOrderDetailsById(id);
            ViewBag.OrderDetail = orderDetail;
            return RedirectToAction("index", "Inventory", new { p = "OrderDetail" });
        }
        [HttpPost]
        public ActionResult OrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.Id > 0)
            {
                InventoryRepository.UpdateOrderDetail(orderDetail);
            }
            else
            {
                InventoryRepository.InsertOrderDetail(orderDetail);
            }
            CommonOrderDetail();
            return RedirectToAction("index", "Inventory", new { p = "OrderDetail" });
        }
        public ActionResult DeleteOrderDetail(int id = 0)
        {
            InventoryRepository.DeleteOrderDetail(id);
            CommonOrderDetail();
            return RedirectToAction("index", "Inventory", new { p = "OrderDetail" });
        }
        #endregion

        #region Product
        public void CommonProduct()
        {
            var productList = InventoryRepository.GetAllProducts();
            ViewBag.ProductList = productList;
        }
        [HttpGet]
        public ActionResult Product(int id =0)
        {
            if (id > 0)
            {
                var product = InventoryRepository.GetProductById(id);
                ViewBag.Product = product;
            }
            CommonProduct();
            return View();
        }
        [HttpPost]
        public ActionResult Product(Product product)
        {
            if (product.Id > 0)
            {
                InventoryRepository.UpdateProduct(product);
            }
            else
            {
                InventoryRepository.InsertProduct(product);
            }
            CommonProduct();
            return RedirectToAction("index", "Inventory", new { p = "Product" });
        }
        public ActionResult ProductDelete(int productId)
        {
            InventoryRepository.DeleteProduct(productId);
            CommonProduct();
            return RedirectToAction("index", "Inventory", new { p = "Product" });
        }
        #endregion

        #region Supplier
        public void CommonSupplier()
        {
            var supplierList = InventoryRepository.GetAllSuppliers();
            ViewBag.SupplierList = supplierList;
        }
        [HttpGet]
        public ActionResult Supplier(int id = 0)
        {
            if (id > 0)
            {
                var supplier = InventoryRepository.GetSupplierById(id);
                ViewBag.Supplier = supplier;
            }
            CommonSupplier();
            return View();
        }
        [HttpPost]
        public ActionResult Supplier(Supplier supplier)
        {
            if (supplier.Id > 0)
            {
                InventoryRepository.UpdateSupplier(supplier);
            }
            else
            {
                InventoryRepository.InsertSupplier(supplier);
            }
            CommonSupplier();
            return RedirectToAction("index", "Inventory", new { p = "Supplier" });
        }
        public ActionResult SupplierDelete(int supplierId)
        {
            InventoryRepository.DeleteSupplier(supplierId);
            CommonSupplier();
            return RedirectToAction("index", "Inventory", new { p = "Supplier" });

        }
        #endregion

    }
}