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
            var branchList = SmsRepository.GetListBranches();
            ViewBag.BranchList = branchList;
        }
        [HttpGet]
        public PartialViewResult Branch(int id = 0)
        {
            if (id > 0)
            {
                var branch = SmsRepository.GetBranchByCityId(id);
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
        [HttpGet]
        public PartialViewResult City()
        {
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

        //Usama Ikram Code 9-22-2016
        #region Module
        public void ModuleCommon()
        {
            var moduleList = SmsRepository.GetAllModule();
            ViewBag.ModuleList = moduleList;
        }
        [HttpGet]
        public PartialViewResult Module(int id = 0)
        {
            var moduleobj = new Module();
            if (id > 0)
            {
                var module=SmsRepository.GetModuleById(id);
                ViewBag.Module = module;
            }
            var subjectList = SmsRepository.GetAllSubject();
            ViewBag.SubjectList = subjectList;
            ViewBag.ModuleObj = moduleobj;
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
            var previousSchoolObj = new PreviousSchool();

            if (id > 0)
            {
                var previousSchool = SmsRepository.GetPreviousSchoolById(id);
                ViewBag.PreviousSchool = previousSchool;
            }

            var studentList = SmsRepository.GetAllStudents();
            ViewBag.StudentList = studentList;
            ViewBag.PreviousSchoolObj = previousSchoolObj;
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
            var sectionObj = new Section();
            if (id > 0)
            {
                var section = SmsRepository.GetSectionById(id);
                ViewBag.Section = section;
            }
            var classList = SmsRepository.GetAllClasses();
            ViewBag.ClassList = classList;
            ViewBag.SectionObj = sectionObj;
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
            var sessionObj = new Session();
            if (id > 0)
            {
                var session = SmsRepository.GetSessionById(id);
                ViewBag.Session = session;
            }
            ViewBag.SessionObj = sessionObj;
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
            var subjectObj = new Subject();
            if (id > 0)
            {
                var subject = SmsRepository.GetSubjectById(id);
                ViewBag.Subject = subject;
            }
            ViewBag.SubjectObj = subjectObj;
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


        //public PartialViewResult Class()
        //{
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

        //    return PartialView("Class");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteClass(int id = 0)
        //{
        //    SmsRepository.DeleteClass(id);
        //    return PartialView("Class");
        //}

        //public PartialViewResult Module()
        //{
        //    return PartialView("Module");
        //}
        //[HttpPost]
        //public PartialViewResult Module(Module module)
        //{
        //    if (module.Id > 0)
        //    {
        //        SmsRepository.UpdateModule(module);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertModule(module);
        //    }

        //    return PartialView("Module");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteModule(int id = 0)
        //{
        //    SmsRepository.DeleteModule(id);
        //    return PartialView("Module");
        //}

        //public PartialViewResult PreviousSchool()
        //{
        //    return PartialView("PreviousSchool");
        //}
        //[HttpPost]
        //public PartialViewResult PreviousSchool(PreviousSchool previousSchool)
        //{
        //    if (previousSchool.Id > 0)
        //    {
        //        SmsRepository.UpdatePreviousSchool(previousSchool);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertPreviousSchool(previousSchool);
        //    }

        //    return PartialView("PreviousSchool");
        //}
        //[HttpPost]
        //public PartialViewResult DeletePreviousSchool(int id = 0)
        //{
        //    SmsRepository.DeletePreviousSchool(id);
        //    return PartialView("PreviousSchool");
        //}

        //public PartialViewResult Section()
        //{
        //    return PartialView("Section");
        //}
        //[HttpPost]
        //public PartialViewResult Section(Section section)
        //{
        //    if (section.Id > 0)
        //    {
        //        SmsRepository.UpdateSection(section);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertSection(section);
        //    }

        //    return PartialView("Section");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteSection(int id = 0)
        //{
        //    SmsRepository.DeleteSection(id);
        //    return PartialView("Section");
        //}

        //public PartialViewResult Session()
        //{
        //    return PartialView("Session");
        //}
        //[HttpPost]
        //public PartialViewResult Session(Session session)
        //{
        //    if (session.Id > 0)
        //    {
        //        SmsRepository.UpdateSession(session);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertSessions(session);
        //    }

        //    return PartialView("Session");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteSession(int id = 0)
        //{
        //    SmsRepository.DeleteSession(id);
        //    return PartialView("Session");
        //}

        //public PartialViewResult Subject()
        //{
        //    return PartialView("Subject");
        //}
        //[HttpPost]
        //public PartialViewResult Subject(Subject subject)
        //{
        //    if (subject.Id > 0)
        //    {
        //        SmsRepository.UpdateSubject(subject);
        //    }
        //    else
        //    {
        //        SmsRepository.InsertSubjects(subject);
        //    }

        //    return PartialView("Subject");
        //}
        //[HttpPost]
        //public PartialViewResult DeleteSubject(int id = 0)
        //{
        //    SmsRepository.DeleteSubject(id);
        //    return PartialView("Subject");
        //}
	}
}