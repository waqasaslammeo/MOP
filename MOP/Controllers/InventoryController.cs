using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public PartialViewResult Category()
        {
            return PartialView("Category");
        }

        public PartialViewResult Customer()
        {
            return PartialView("Customer");
        }

        public PartialViewResult Employee()
        {
            return PartialView("Employee");
        }

        public PartialViewResult Order()
        {
            return PartialView("Order");
        }

        public PartialViewResult Product()
        {
            return PartialView("Product");
        }
	}
}