using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Common;
using MOP.SMS;
using MOP.Models;

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

        #region Branch

        public void BranchCommon()
        {
            var branchList = SmsRepository.getAllBranchs();
            ViewBag.BranchList = branchList;
        }
        [HttpGet]
        public PartialViewResult Branch(int id = 0)
        {
            if (id > 0)
            {
                var branch = SmsRepository.GetBranchById(id);
                ViewBag.Branch = branch;
            }
            BranchCommon();

            return PartialView("Branch");
        }
        [HttpPost]
        public PartialViewResult Branch(Branch branch)
        {
            if (branch.Id > 0)
            {
                SmsRepository.UpdateBranch(branch);
            }
            else
            {
                SmsRepository.InsertBranch(branch);
            }

            BranchCommon();

            return PartialView("Branch");
        }
        [HttpPost]
        public PartialViewResult DeleteBranch(int id = 0)
        {
            SmsRepository.DeleteBranch(id);
            BranchCommon();
            return PartialView("Branch");
        }

        #endregion

        #region City
        public PartialViewResult City()
        {
            return PartialView("City");
        }
        public PartialViewResult City(City city)
        {
            if (city.Id > 0)
            {
                SmsRepository.UpdateCity(city);
            }
            else
            {
                SmsRepository.InsertCity(city);
            }

            return PartialView("City");
        }
        [HttpPost]
        public PartialViewResult DeleteCity(int id = 0)
        {
            SmsRepository.DeleteCity(id);
            return PartialView("City");
        }
        #endregion

        #region Company
        [HttpGet]
        public PartialViewResult Company()
        {
            return PartialView("Company");
        }
        [HttpPost]
        public PartialViewResult Company(Company company)
        {
            if (company.Id > 0)
            {
                SmsRepository.UpdateCompany(company);
            }
            else
            {
                SmsRepository.InsertCompany(company);
            }

            return PartialView("Company");
        }
        [HttpPost]
        public PartialViewResult DeleteCompany(int id = 0)
        {
            SmsRepository.DeleteCompany(id);
            return PartialView("Company");
        }
        #endregion

        #region Grade
        public PartialViewResult Grade()
        {
            return PartialView("Grade");
        }
        [HttpPost]
        public PartialViewResult Grade(Grade grade)
        {
            if (grade.Id > 0)
            {
                SmsRepository.UpdateGrade(grade);
            }
            else
            {
                SmsRepository.InsertGrade(grade);
            }

            return PartialView("Grade");
        }
        [HttpPost]
        public PartialViewResult DeleteGrade(int id = 0)
        {
            SmsRepository.DeleteGrade(id);
            return PartialView("Grade");
        }
        #endregion
       
       

     

        public PartialViewResult Class()
        {
            return PartialView("Class");
        }
        [HttpPost]
        public PartialViewResult Class(Class cClass)
        {
            if (cClass.Id > 0)
            {
                SmsRepository.UpdateClass(cClass);
            }
            else
            {
                SmsRepository.InsertClass(cClass);
            }

            return PartialView("Class");
        }
        [HttpPost]
        public PartialViewResult DeleteClass(int id = 0)
        {
            SmsRepository.DeleteClass(id);
            return PartialView("Class");
        }

        public PartialViewResult Module()
        {
            return PartialView("Module");
        }
        [HttpPost]
        public PartialViewResult Module(Module module)
        {
            if (module.Id > 0)
            {
                SmsRepository.UpdateModule(module);
            }
            else
            {
                SmsRepository.InsertModule(module);
            }

            return PartialView("Module");
        }
        [HttpPost]
        public PartialViewResult DeleteModule(int id = 0)
        {
            SmsRepository.DeleteModule(id);
            return PartialView("Module");
        }

        public PartialViewResult PreviousSchool()
        {
            return PartialView("PreviousSchool");
        }
        [HttpPost]
        public PartialViewResult PreviousSchool(PreviousSchool previousSchool)
        {
            if (previousSchool.Id > 0)
            {
                SmsRepository.UpdatePreviousSchool(previousSchool);
            }
            else
            {
                SmsRepository.InsertPreviousSchool(previousSchool);
            }

            return PartialView("PreviousSchool");
        }
        [HttpPost]
        public PartialViewResult DeletePreviousSchool(int id = 0)
        {
            SmsRepository.DeletePreviousSchool(id);
            return PartialView("PreviousSchool");
        }

        public PartialViewResult Section()
        {
            return PartialView("Section");
        }
        [HttpPost]
        public PartialViewResult Section(Section section)
        {
            if (section.Id > 0)
            {
                SmsRepository.UpdateSection(section);
            }
            else
            {
                SmsRepository.InsertSection(section);
            }

            return PartialView("Section");
        }
        [HttpPost]
        public PartialViewResult DeleteSection(int id = 0)
        {
            SmsRepository.DeleteSection(id);
            return PartialView("Section");
        }

        public PartialViewResult Session()
        {
            return PartialView("Session");
        }
        [HttpPost]
        public PartialViewResult Session(Session session)
        {
            if (session.Id > 0)
            {
                SmsRepository.UpdateSession(session);
            }
            else
            {
                SmsRepository.InsertSessions(session);
            }

            return PartialView("Session");
        }
        [HttpPost]
        public PartialViewResult DeleteSession(int id = 0)
        {
            SmsRepository.DeleteSession(id);
            return PartialView("Session");
        }

        public PartialViewResult Subject()
        {
            return PartialView("Subject");
        }
        [HttpPost]
        public PartialViewResult Subject(Subject subject)
        {
            if (subject.Id > 0)
            {
                SmsRepository.UpdateSubject(subject);
            }
            else
            {
                SmsRepository.InsertSubjects(subject);
            }

            return PartialView("Subject");
        }
        [HttpPost]
        public PartialViewResult DeleteSubject(int id = 0)
        {
            SmsRepository.DeleteSubject(id);
            return PartialView("Subject");
        }
	}
}