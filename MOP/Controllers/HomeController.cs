using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Models;
using Test2;


namespace MOP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var c = new SmsContext();
            var r = PartialSmsRepositoryNaqash.GetAllRoles(c);
            
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }

        public PartialViewResult demo1()
        {
            return PartialView("demo1");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}