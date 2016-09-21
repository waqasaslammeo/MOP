using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Common;
using MOP.Context;
using MOP.Models;
using MOP.SMS;

namespace MOP.Controllers
{
    public class SmsController : Controller
    {
        // GET: Sms
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string username, string password)
        {
            using (var db = new AlphaContext())
            {
                var tempUser = db.Users.Single(x => x.Username == username && x.Password == password);
                if (tempUser != null)
                {
                    Session["UserId"] = Convert.ToInt32(tempUser.Id);
                    Session["username"] = tempUser.Username.ToList();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "username or password is Incorrect..!");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public PartialViewResult City()
        {
            return PartialView("City");
        }
        public PartialViewResult Grade()
        {
            return PartialView("Grade");
        }
        public PartialViewResult Sessions()
        {
            return PartialView("Session");
        }
        public PartialViewResult Subject()
        {
            return PartialView("Subject");
        }
        public PartialViewResult Branch()
        {
            return PartialView("Branch");
        }
        public PartialViewResult Module()
        {
            return PartialView("Module");
        }
    }
}