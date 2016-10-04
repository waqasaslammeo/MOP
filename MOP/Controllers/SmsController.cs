using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MOP.Common;
using MOP.Models.SMS;
using MOP.Models;
namespace MOP.Controllers
{
    public class SMSController : Controller
    {
        //
        // GET: /SMS/b
        public ActionResult Index()
        {
           
            return View();
        }
        #region Branch
        public void BranchCommon()
        {
            var branchList = SmsRepository.GetListBranches();
            ViewBag.BranchList = branchList;
        }
        
        [HttpGet]
        public ActionResult Branch(int id = 0)
        {
            if (id > 0)
            {
                var branch = SmsRepository.GetBranchById(id);
                ViewBag.Branch = branch;
            }
            var tempAllcity = SmsRepository.GetListCities();
            ViewBag.CityList = tempAllcity;
            BranchCommon();

            return View();
        }
        [HttpPost]
        public ActionResult Branch(Branch branch)
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

            return RedirectToAction("index", "sms", new { p = "Branch" });
        }
        public ActionResult DeleteBranch(int id = 0)
        {
            SmsRepository.DeleteBranch(id);
            BranchCommon();
            return RedirectToAction("index", "sms", new { p = "Branch" });
        }
        #endregion
        #region City
        public void CityCommon()
        {
            var cityList = SmsRepository.GetListCities();
            ViewBag.CityList = cityList;
        }
        [HttpGet]
        public ActionResult City(int id = 0)
        {
            if (id > 0)
            {
                var city = SmsRepository.GetCityById(id);
                ViewBag.City = city;
            }
            CityCommon();
            return View();
        }
        [HttpPost]
        public ActionResult City(City city)
        {
            if (city.Id > 0)
            {
                SmsRepository.UpdateCity(city);
            }
            else
            {
                SmsRepository.InsertCity(city);
            }
            CityCommon();
            return RedirectToAction("index", "sms", new { p = "City" });
        }
        public ActionResult DeleteCity(int id = 0)
        {
            SmsRepository.DeleteCity(id);
            CityCommon();
            return RedirectToAction("index", "sms", new { p = "City" });
        }
        #endregion
        //#region Company
        //public void CompanyCommon()
        //{
        //    var companyList = SmsRepository.GetListCompanies();
        //    ViewBag.CompanyList = companyList;
        //}
        //[HttpGet]
        //public PartialViewResult Company(int id = 0)
        //{
        //    if (id > 0)
        //    {
        //        var company = SmsRepository.GetCompanyById(id);
        //        ViewBag.Company = company;
        //    }
        //    CompanyCommon();
        //    return PartialView("Company");
        //}
        //[HttpPost]
        //public PartialViewResult Company(Company company)
        //{
        //    if (company.Id > 0)
        //    {
        //        SmsRepository.UpdateCompany(company);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertCompany(company);
        //    }
        //    CompanyCommon();
        //    return PartialView("Company");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteCompany(int id = 0)
        //{
        //    SmsRepository.DeleteCompany(id);
        //    CompanyCommon();
        //    return PartialView("Company");
        //}
        //#endregion
        #region Grade

        public void GradeCommon()
        {
            var gradeList = SmsRepository.GetAllGrades();
            ViewBag.GradeList = gradeList;
        }
        [HttpGet]
        public ActionResult Grade(int id=0) 
        {
            if (id > 0)
            {
                var grade = SmsRepository.GetGradeById(id);
                ViewBag.Grade = grade;
            }
            GradeCommon();
            return View();
        }
        [HttpPost]
        public ActionResult Grade(Grade grade)
        {
            if (grade.Id > 0)
            {
                SmsRepository.UpdateGrade(grade);
            }
            else
            {
                SmsRepository.InsertGrade(grade);
            }
            GradeCommon();
            return RedirectToAction("index", "sms", new { p = "Grade" });
        }
        public ActionResult DeleteGrade(int id = 0)
        {
            SmsRepository.DeleteGrade(id);
            GradeCommon();
            return RedirectToAction("index", "sms", new { p = "Grade" });
        }
        #endregion
        #region Class
        public void ClassCommon()
        {
            var classList = SmsRepository.GetAllClasses();
            ViewBag.ClassList = classList;
        }
        [HttpGet]
        public ActionResult Class(int id=0)
        {
            if (id > 0)
            {
                var cClass = SmsRepository.GetClassById(id);
                ViewBag.Class = cClass;
            }
            var tempAllgrade = SmsRepository.GetAllGrades();
            ViewBag.GradeList = tempAllgrade;
            ClassCommon();
            return View();
        }
        [HttpPost]
        public ActionResult Class(Class cClass)
        {
            if (cClass.Id > 0)
            {
                SmsRepository.UpdateClass(cClass);
            }
            else
            {
                SmsRepository.InsertClass(cClass);
            }
            ClassCommon();
            return RedirectToAction("index", "sms", new { p = "Class" });
        }
        [HttpPost]
        public ActionResult DeleteClass(int id = 0)
        {
            SmsRepository.DeleteClass(id);
            ClassCommon();
            return RedirectToAction("index", "sms", new { p = "Class" });
        }

        #endregion 
        #region Module
        public void ModuleCommon()
        {
            var moduleList = SmsRepository.GetAllModule();
            ViewBag.ModuleList = moduleList;
        }
        [HttpGet]
        public ActionResult Module(int id = 0)
        {
            if (id > 0)
            {
                var module = SmsRepository.GetModuleById(id);
                ViewBag.Module = module;
            }
            var subjectList = SmsRepository.GetAllSubject();
            ViewBag.SubjectList = subjectList;   
            ModuleCommon();
            return View();
        }
        [HttpPost]
        public ActionResult Module(Module module)
        {
            if (module.Id > 0)
            {
                SmsRepository.UpdateModule(module);
            }
            else
            {
                SmsRepository.InsertModule(module);
            }
            ModuleCommon();
            return View();
        }
        [HttpPost]
        public ActionResult DeleteModule(int id = 0)
        {
            SmsRepository.DeleteModule(id);
            ModuleCommon();
            return View();
        }
        
        #endregion
        #region Previous School
        public void PreviousSchoolCommon()
        {
            var previousSchoolList = SmsRepository.GetAllPreviousSchools();
            ViewBag.PreviousSchoolList = previousSchoolList;
        }
        [HttpGet]
        public ActionResult PreviousSchool(int id = 0)
        {
            if (id > 0)
            {
                var previousSchool = SmsRepository.GetPreviousSchoolByStudentId(id);
                ViewBag.PreviousSchool = previousSchool;
            }
            var tempStudent = SmsRepository.GetAllStudents();
            ViewBag.StudentList = tempStudent;
            PreviousSchoolCommon();
            return View();
        }

        [HttpPost]
        public ActionResult PreviousSchool(PreviousSchool previousSchool)
        {
            if (previousSchool.Id > 0)
            {
                SmsRepository.UpdatePreviousSchool(previousSchool);
            }
            else
            {
                SmsRepository.InsertPreviousSchool(previousSchool);
            }
            PreviousSchoolCommon();
            return View();
        }

        public ActionResult DeletePreviousSchool(int id = 0)
        {
            SmsRepository.DeletePreviousSchool(id);
            PreviousSchoolCommon();
            return View();
        }
        #endregion
        #region Section
        public void SectionCommon()
        {
            var sectionList = SmsRepository.GetAllSections();
            ViewBag.SectionList = sectionList;
        }
        [HttpGet]
        public ActionResult Section(int id = 0)
        {
            if (id > 0)
            {
                var section = SmsRepository.GetSectionById(id);
                ViewBag.Section = section;
            }
            var tempClassList = SmsRepository.GetAllClasses();
            ViewBag.ClassList = tempClassList;
            SectionCommon();
            return View();
        }
        [HttpPost]
        public ActionResult Section(Section section)
        {
            if (section.Id > 0)
            {
                SmsRepository.UpdateSection(section);
            }
            else
            {
                SmsRepository.InsertSection(section);
            }
            SectionCommon();
            return View();
        }
        [HttpPost]
        public ActionResult DeleteSection(int id = 0)
        {
            SmsRepository.DeleteSection(id);
            SectionCommon();
            return View();
        }
        #endregion
        #region Session
        public void SessionCommon()
        {
            var sessionList = SmsRepository.GetAllSession();
            ViewBag.SessionList = sessionList;
        }
        [HttpGet]
        public ActionResult Session(int id = 0)
        {
            if (id > 0)
            {
                var session = SmsRepository.GetSessionById(id);
                ViewBag.Session = session;
            }
            SessionCommon();
            return View();
        }
        [HttpPost]
        public ActionResult Session(Session session)
        {
            if (session.Id > 0)
            {
                SmsRepository.UpdateSession(session);
            }
            else
            {
                SmsRepository.InsertSessions(session);
            }
            SessionCommon();
            return View();
        }
        [HttpPost]
        public PartialViewResult DeleteSession(int id = 0)
        {
            SmsRepository.DeleteSession(id);
            SessionCommon();
            return PartialView("Session");
        }
        #endregion
        #region Subject
        public void SubjectCommon()
        {
            var subjectList = SmsRepository.GetAllSubject();
            ViewBag.SubjectList = subjectList;
        }
        [HttpGet]
        public PartialViewResult Subject(int id = 0)
        {
            if (id > 0)
            {
                var subject = SmsRepository.GetSubjectById(id);
                ViewBag.Subject = subject;
            }
            SubjectCommon();
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
            SubjectCommon();
            return PartialView("Subject");
        }
        [HttpPost]
        public PartialViewResult DeleteSubject(int id = 0)
        {
            SmsRepository.DeleteSubject(id);
            SubjectCommon();
            return PartialView("Subject");
        }
        #endregion
        [HttpGet]
        public ActionResult TestGrade(int id=0)
        {
            if (id > 0)
            {
                var grade = SmsRepository.GetGradeById(id);
                ViewBag.Grade = grade;
            }
            GradeCommon();
            return View();
        }
        [HttpPost]
        public ActionResult TestGrade()
        {
            //if (id > 0)
            {
                var grade = SmsRepository.GetGradeById(1);
                ViewBag.Grade = grade;
            }
            GradeCommon();
            return View();
        }  
	}
}