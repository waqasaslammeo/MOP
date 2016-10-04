using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MOP.Common;
using MOP.Context;
using MOP.Models;
using MOP.Models.SMS;


namespace MOP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var c = new AlphaContext();
            return View(c.Branches.ToList());
        }
        [HttpGet]
        public ActionResult SignUp1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp1(User user)
        {
            using (var db = new AlphaContext())
            {
                var tempUser = db.Users.Single(x => x.Username == user.Username && x.Password == user.Password);
                if (tempUser != null)
                {
                    Session["username"] = tempUser.Username.ToList();
                    return RedirectToAction("demo1");
                }
                else
                {
                    ModelState.AddModelError("","username or password is Incorrect..!");
                }
            }
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

        public PartialViewResult Test1()
        {
            return PartialView("test1");
        }
    }
}