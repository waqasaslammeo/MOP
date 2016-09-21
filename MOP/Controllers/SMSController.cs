using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOP.Controllers
{
    public class SMSController : Controller
    {
        //
        // GET: /SMS/
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Branch()
        {
            return PartialView("Branch");
        }

        public PartialViewResult City()
        {
            return PartialView("City");
        }

        public PartialViewResult Grade()
        {
            return PartialView("Grade");
        }

        public PartialViewResult Class()
        {
            return PartialView("Class");
        }

        public PartialViewResult Module()
        {
            return PartialView("Module");
        }

        public PartialViewResult PreviousSchool()
        {
            return PartialView("PreviousSchool");
        }

        public PartialViewResult Section()
        {
            return PartialView("Section");
        }

        public PartialViewResult Session()
        {
            return PartialView("Session");
        }

        public PartialViewResult Subject()
        {
            return PartialView("Subject");
        }
	}
}