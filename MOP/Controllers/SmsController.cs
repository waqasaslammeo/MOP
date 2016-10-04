using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOP.Common;
using MOP.Models.SMS;
using MOP.Models;

namespace MOP.Controllers
{
    public class SMSController : Controller
    {
       
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
        //public ContentResult GetEditObject(int id, string objName)
        //{
        //    JavaScriptSerializer sr = new JavaScriptSerializer();

        //    if (objName=="Branch")
        //    {
        //        var branch = SmsRepository.GetBranchById(id);

        //        return new ContentResult {Content = sr.Serialize(branch), ContentType = "application/json"};
        //    }
        //    return null;
        //}
        [HttpGet]
        public PartialViewResult Branch(int id = 0)
        {
            if (id > 0)
            {
                var branch = SmsRepository.GetBranchByCityId(id);
                ViewBag.Branch = branch;
            }
            var tempAllcity = SmsRepository.GetListCities();
            ViewBag.CityList = tempAllcity;
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
        public void CityCommon()
        {
            var cityList = SmsRepository.GetListCities();
            ViewBag.CityList = cityList;
        }
        [HttpGet]
        public PartialViewResult City(int id = 0)
        {
            if (id > 0)
            {
                var city = SmsRepository.GetCityById(id);
                ViewBag.City = city;
            }
            CityCommon();
            return PartialView("City");
        }
        [HttpPost]
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
            CityCommon();
            return PartialView("City");
        }
        [HttpPost]
        public PartialViewResult DeleteCity(int id = 0)
        {
            SmsRepository.DeleteCity(id);
            CityCommon();
            return PartialView("City");
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
        public PartialViewResult Grade(int id = 0)
        {
            if (id > 0)
            {
                var grade = SmsRepository.GetGradeById(id);
                ViewBag.Grade = grade;
            }
            GradeCommon();
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
            GradeCommon();
            return PartialView("Grade");
        }
        [HttpPost]
        public PartialViewResult DeleteGrade(int id = 0)
        {
            SmsRepository.DeleteGrade(id);
            GradeCommon();
            return PartialView("Grade");
        }
        #endregion
        #region Class
        public void ClassCommon()
        {
            var classList = SmsRepository.GetAllClasses();
            ViewBag.ClassList = classList;
        }
        [HttpGet]
        public PartialViewResult Class(int id = 0)
        {
            if (id > 0)
            {
                var cClass = SmsRepository.GetClassById(id);
                ViewBag.Class = cClass;
            }
            var tempAllgrade = SmsRepository.GetAllGrades();
            ViewBag.GradeList = tempAllgrade;
            ClassCommon();
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
            ClassCommon();
            return PartialView("Class");
        }
        [HttpPost]
        public PartialViewResult DeleteClass(int id = 0)
        {
            SmsRepository.DeleteClass(id);
            ClassCommon();
            return PartialView("Class");
        }

        #endregion 
        //#region Branch
        //public void BranchCommon()
        //{
        //    var branchList = SmsRepository.GetListBranches();
        //    ViewBag.BranchList = branchList;
        //}
        //[HttpGet]
        //public PartialViewResult Branch(int id = 0)
        //{
        //    if (id > 0)
        //    {
        //        var branch = SmsRepository.GetBranchByCityId(id);
        //        ViewBag.Branch = branch;
        //    }
        //    var tempAllcity = SmsRepository.GetListCities();
        //    ViewBag.CityList = tempAllcity;
        //    BranchCommon();

        //    return PartialView("Branch");
        //}
        //[HttpPost]
        //public PartialViewResult Branch(Branch branch)
        //{
        //    if (branch.Id > 0)
        //    {
        //        SmsRepository.UpdateBranch(branch);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertBranch(branch);
        //    }

        //    BranchCommon();

        //    return PartialView("Branch");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteBranch(int id = 0)
        //{
        //    SmsRepository.DeleteBranch(id);
        //    BranchCommon();
        //    return PartialView("Branch");
        //}

        //#endregion

        //#region City
        //public void CityCommon()
        //{
        //    var cityList = SmsRepository.GetListCities();
        //    ViewBag.CityList = cityList;
        //}
        //[HttpGet]
        //public PartialViewResult City(int id = 0)
        //{
        //    if (id > 0)
        //    {
        //        var city = SmsRepository.GetCityById(id);
        //        ViewBag.City = city;
        //    }
        //    CityCommon();
        //    return PartialView("City");
        //}
        //[HttpPost]
        //public PartialViewResult City(City city)
        //{
        //    if (city.Id > 0)
        //    {
        //        SmsRepository.UpdateCity(city);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertCity(city);
        //    }
        //    CityCommon();
        //    return PartialView("City");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteCity(int id = 0)
        //{
        //    SmsRepository.DeleteCity(id);
        //    CityCommon();
        //    return PartialView("City");
        //}
        //#endregion

        ////#region Company
        ////public void CompanyCommon()
        ////{
        ////    var companyList = SmsRepository.GetListCompanies();
        ////    ViewBag.CompanyList = companyList;
        ////}
        ////[HttpGet]
        ////public PartialViewResult Company(int id = 0)
        ////{
        ////    if (id > 0)
        ////    {
        ////        var company = SmsRepository.GetCompanyById(id);
        ////        ViewBag.Company = company;
        ////    }
        ////    CompanyCommon();
        ////    return PartialView("Company");
        ////}
        ////[HttpPost]
        ////public PartialViewResult Company(Company company)
        ////{
        ////    if (company.Id > 0)
        ////    {
        ////        SmsRepository.UpdateCompany(company);
        ////    }
        ////    else
        ////    {
        ////        SmsRepository.InsertCompany(company);
        ////    }
        ////    CompanyCommon();
        ////    return PartialView("Company");
        ////}
        ////[HttpPost]
        ////public PartialViewResult DeleteCompany(int id = 0)
        ////{
        ////    SmsRepository.DeleteCompany(id);
        ////    CompanyCommon();
        ////    return PartialView("Company");
        ////}
        ////#endregion

        //#region Grade

        //public void GradeCommon()
        //{
        //    var gradeList = SmsRepository.GetAllGrades();
        //    ViewBag.GradeList = gradeList;
        //}
        //[HttpGet]
        //public PartialViewResult Grade(int id=0) 
        //{
        //    if (id > 0)
        //    {
        //        var grade = SmsRepository.GetGradeById(id);
        //        ViewBag.Grade = grade;
        //    }
        //    GradeCommon();
        //    return PartialView("Grade");
        //}
        //[HttpPost]
        //public PartialViewResult Grade(Grade grade)
        //{
        //    if (grade.Id > 0)
        //    {
        //        SmsRepository.UpdateGrade(grade);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertGrade(grade);
        //    }
        //    GradeCommon();
        //    return PartialView("Grade");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteGrade(int id = 0)
        //{
        //    SmsRepository.DeleteGrade(id);
        //    GradeCommon();
        //    return PartialView("Grade");
        //}
        //#endregion
       
        //#region Class
        //public void ClassCommon()
        //{
        //    var classList = SmsRepository.GetAllClasses();
        //    ViewBag.ClassList = classList;
        //}
        //[HttpGet]
        //public PartialViewResult Class(int id=0)
        //{
        //    if (id > 0)
        //    {
        //        var cClass = SmsRepository.GetClassById(id);
        //        ViewBag.Class = cClass;
        //    }
        //    var tempAllgrade = SmsRepository.GetAllGrades();
        //    ViewBag.GradeList = tempAllgrade;
        //    ClassCommon();
        //    return PartialView("Class");
        //}
        //[HttpPost]
        //public PartialViewResult Class(Class cClass)
        //{
        //    if (cClass.Id > 0)
        //    {
        //        SmsRepository.UpdateClass(cClass);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertClass(cClass);
        //    }
        //    ClassCommon();
        //    return PartialView("Class");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteClass(int id = 0)
        //{
        //    SmsRepository.DeleteClass(id);
        //    ClassCommon();
        //    return PartialView("Class");
        //}

        //#endregion 
        #region Module
        public void ModuleCommon()
        {
            var moduleList = SmsRepository.GetAllModule();
            ViewBag.ModuleList = moduleList;
        }
        [HttpGet]
        public PartialViewResult Module(int id = 0)
        {
            if (id > 0)
            {
                var module = SmsRepository.GetModuleById(id);
                ViewBag.Module = module;
            }
            var subjectList = SmsRepository.GetAllSubject();
            ViewBag.SubjectList = subjectList;
            ModuleCommon();
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
            ModuleCommon();
            return PartialView("Module");
        }
        [HttpPost]
        public PartialViewResult DeleteModule(int id = 0)
        {
            SmsRepository.DeleteModule(id);
            ModuleCommon();
            return PartialView("Module");
        }

        #endregion
        #region Previous School
        public void PreviousSchoolCommon()
        {
            var previousSchoolList = SmsRepository.GetAllPreviousSchools();
            ViewBag.PreviousSchoolList = previousSchoolList;
        }
        [HttpGet]
        public PartialViewResult PreviousSchool(int id = 0)
        {
            if (id > 0)
            {
                var previousSchool = SmsRepository.GetPreviousSchoolByStudentId(id);
                ViewBag.PreviousSchool = previousSchool;
            }
            var tempStudent = SmsRepository.GetAllStudents();
            ViewBag.StudentList = tempStudent;
            PreviousSchoolCommon();
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
            PreviousSchoolCommon();
            return PartialView("PreviousSchool");
        }

        public PartialViewResult DeletePreviousSchool(int id = 0)
        {
            SmsRepository.DeletePreviousSchool(id);
            PreviousSchoolCommon();
            return PartialView("PreviousSchool");
        }
        #endregion
        #region Section
        public void SectionCommon()
        {
            var sectionList = SmsRepository.GetAllSections();
            ViewBag.SectionList = sectionList;
        }
        [HttpGet]
        public PartialViewResult Section(int id = 0)
        {
            if (id > 0)
            {
                var section = SmsRepository.GetSectionById(id);
                ViewBag.Section = section;
            }
            var tempClassList = SmsRepository.GetAllClasses();
            ViewBag.ClassList = tempClassList;
            SectionCommon();
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
            SectionCommon();
            return PartialView("Section");
        }
        [HttpPost]
        public PartialViewResult DeleteSection(int id = 0)
        {
            SmsRepository.DeleteSection(id);
            SectionCommon();
            return PartialView("Section");
        }
        #endregion
        #region Session
        public void SessionCommon()
        {
            var sessionList = SmsRepository.GetAllSession();
            ViewBag.SessionList = sessionList;
        }
        [HttpGet]
        public PartialViewResult Session(int id = 0)
        {
            if (id > 0)
            {
                var session = SmsRepository.GetSessionById(id);
                ViewBag.Session = session;
            }
            SessionCommon();
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
            SessionCommon();
            return PartialView("Session");
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

        

      
   

        
	}
}