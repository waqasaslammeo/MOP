using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Common;
using MOP.Inventory;

namespace MOP.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Category()
        {
            return PartialView("Category");
        }
        [HttpPost]
        public PartialViewResult Category(Category category)
        {
            if (category.Id > 0)
            {
                InventoryRepository.UpdateCategory(category);
            }
            else
            {
                InventoryRepository.InsertCategory(category);
            }
            return PartialView("Category");
        }
        [HttpPost]
        public PartialViewResult DeleteCategory(int categoryId)
        {
            InventoryRepository.DeleteCategory(categoryId);
            return PartialView("Category");
        }
        [HttpGet]
        public PartialViewResult Customer()
        {
            return PartialView("Customer");
        }
        [HttpPost]
        public PartialViewResult Customer(Customer customer)
        {
            if (customer.Id > 0)
            {
                InventoryRepository.UpdateCustomer(customer);
            }
            else
            {
                InventoryRepository.InsertCustomer(customer);
            }
            return PartialView("Customer");
        }
        [HttpPost]
        public PartialViewResult Customer(int customerId)
        {
            InventoryRepository.DeleteCustomer(customerId);
            return PartialView("Customer");
        }
        [HttpGet]
        public PartialViewResult Employee()
        {
            return PartialView("Employee");
        }
        [HttpPost]
        public PartialViewResult Employee(Employee employee)
        {
            if (employee.Id > 0)
            {
                InventoryRepository.UpdateEmployee(employee);
            }
            else
            {
                InventoryRepository.InsertEmployee(employee);
            }
            return PartialView("Employee");
        }
        [HttpPost]
        public PartialViewResult Employee(int employeeId)
        {
            InventoryRepository.DeleteEmployee(employeeId);
            return PartialView("Employee");
        }
        [HttpGet]
        public PartialViewResult Order()
        {
            return PartialView("Order");
        }
        [HttpPost]
        public PartialViewResult Order(Order order)
        {
            if (order.Id > 0)
            {
             InventoryRepository.UpdateOrder(order);   
            }
            else
            {
                InventoryRepository.InsertOrder(order);
            }
            return PartialView("Order");
        }
        [HttpPost]
        public PartialViewResult Order(int orderId)
        {
            InventoryRepository.DeleteOrder(orderId);
            return PartialView("Order");
        }
        [HttpGet]
        public PartialViewResult Product()
        {
            return PartialView("Product");
        }
        [HttpPost]
        public PartialViewResult Product(Product product)
        {
            if (product.Id > 0)
            {
                InventoryRepository.UpdateProduct(product);
            }
            else
            {
                InventoryRepository.InsertProduct(product);
            }
            return PartialView("Product");
        }
        [HttpPost]
        public PartialViewResult Product(int productId)
        {
            InventoryRepository.DeleteProduct(productId);
            return PartialView("Product");
        }
	}
}