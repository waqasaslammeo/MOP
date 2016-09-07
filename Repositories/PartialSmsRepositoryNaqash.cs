using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BusinessEntity.SMS;
using BusinessEntity.Context;

namespace Repositories
{
     partial class PartialSmsRepositoryNaqash
    {
        #region Get
        public static Class GetClassById(int classId)
        {
            Class classobj = new Class();

            using (SMSContext db = new SMSContext())
            {
                classobj = db.Classes.Single(x => x.Id == classId);
            }
            return classobj;
        }
        public static Section GetSectionById(int sectionId)
        {
            var section = new Section();
            using (SMSContext db = new SMSContext())
            {
                section = db.Sections.Single(x => x.Id == sectionId);
            }
            return section;
        }
        public static Grade GetGradeById(int gradeId)
        {
            var grade = new Grade();
            using (SMSContext db = new SMSContext())
            {
                grade = db.Grades.Single(x => x.Id == gradeId);
            }
            return grade;

        }
        public static Module GetModuleById(int moduleId)
        {
            var moduleobj = new Module();

            using (SMSContext db = new SMSContext())
            {
                moduleobj = db.Modules.Single(x => x.Id == moduleId);
            }
            return moduleobj;
        }
        public static Session GetSessionById(int sessionId)
        {
            var sessionObj = new Session();

            using (SMSContext db = new SMSContext())
            {
                sessionObj = db.Sessions.Single(x => x.Id == sessionId);
            }
            return sessionObj;
        }
        public static Subject GetSubjectById(int subjectId)
        {
            var subjectObj = new Subject();

            using (SMSContext db = new SMSContext())
            {
                subjectObj = db.Subjects.Single(x => x.Id == subjectId);
            }
            return subjectObj;
        }
        public static SystemItem GetSystemItemById(int systemId)
        {
            var systemItemObj = new SystemItem();

            using (SMSContext db = new SMSContext())
            {
                systemItemObj = db.SystemItems.Single(x => x.Id == systemId);
            }
            return systemItemObj;
        }
        public static User GetUserById(int userId)
        {
            var userObj = new User();

            using (SMSContext db = new SMSContext())
            {
                userObj = db.Users.Single(x => x.Id == userId);
            }
            return userObj;
        }
        public static Role GetRoleById(int roleId)
        {
            Role roleobj = new Role();
            using (SMSContext db = new SMSContext())
            {
                roleobj = db.Roles.Single(x => x.Id == roleId);
            }
            return roleobj;
        }
        #endregion
        #region List
        public static List<Class> GetAllClasses()
        {
            var classList = new List<Class>();

            using (SMSContext db = new SMSContext())
            {
                classList = db.Classes.ToList();
            }

            return classList;
        }

        public static List<Section> GetAllSections()
        {
            var sectionList = new List<Section>();
            using (SMSContext db = new SMSContext())
            {
                sectionList = db.Sections.ToList();
            }
            return sectionList;
        }

        public static List<Grade> GetAllGrades()
        {
            var gradeList = new List<Grade>();
            using (SMSContext db = new SMSContext())
            {
                gradeList = db.Grades.ToList();
            }
            return gradeList;
        }
        #endregion
        #region Insert

         public static void InsertClass(Class classObj)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Classes.Add(classObj);
                 db.SaveChanges();
             }
         }
         public static void InsertSection(Section section)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Sections.Add(section);
                 db.SaveChanges();
             }
         }
         public static void InsertGrade(Grade grade)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Grades.Add(grade);
                 db.SaveChanges();
             }
         }
         public static void InsertModule(Module module)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Modules.Add(module);
                 db.SaveChanges();
             }
         }
         public static void InsertSessions(Session session)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Sessions.Add(session);
                 db.SaveChanges();
             }
         }
         public static void InsertSubjects(Subject subject)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Subjects.Add(subject);
                 db.SaveChanges();
             }
         }
         public static void InsertSystemItem(SystemItem systemItem)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.SystemItems.Add(systemItem);
                 db.SaveChanges();
             }
         }
         public static void InsertUser(User user)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Users.Add(user);
                 db.SaveChanges();
             }
         }
         public static void InsertRole(Role role)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.Roles.Add(role);
                 db.SaveChanges();
             }
         }

        #endregion
        #region Update
         public static void UpdateClass(Class classObj)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempClass = db.Classes.Single(x => x.Id == classObj.Id);
                 tempClass.ClassName = classObj.ClassName;
                 tempClass.GradeId = classObj.GradeId;
                 tempClass.Grade = classObj.Grade;
                 db.SaveChanges();
             }
         }

         public static void UpdateSection(Section section)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSection = db.Sections.Single(x => x.Id == section.Id);
                 tempSection.SectionName = section.SectionName;
                 tempSection.ClassId = section.ClassId;
                 tempSection.Class = section.Class;
                 db.SaveChanges();
             }
             {
                 
             }
         }

         public static void UpdateGrade(Grade grade)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempGrade = db.Grades.Single(x => x.Id == grade.Id);
                 tempGrade.Grades = grade.Grades;
                 db.SaveChanges();
             }
         }
         public static void UpdateModule(Module module)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempModule = db.Modules.Single(x => x.Id == module.Id);
                 tempModule.ModuleName = module.ModuleName;
                 tempModule.Subject = module.Subject;
                 tempModule.SubjectId = module.SubjectId;
                 db.SaveChanges();
             }
         }

         public static void UpdateSession(Session session)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSession = db.Sessions.Single(x => x.Id == session.Id);
                 tempSession.SessionName = session.SessionName;
                 tempSession.IsCurrent = session.IsCurrent;
                 db.SaveChanges();
             }
         }

         public static void UpdateSubject(Subject subject)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSubject = db.Subjects.Single(x => x.Id == subject.Id);
                 tempSubject.SubjectName = subject.SubjectName;
                 tempSubject.Abbreviation = subject.Abbreviation;
                 db.SaveChanges();
             }
         }
         public static void UpdateSystemItem(SystemItem systemItem)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItem.Id);
                 tempSystemItem.SystemItemName = systemItem.SystemItemName;
                 tempSystemItem.IsActive = systemItem.IsActive;
                 db.SaveChanges();
             }
         }
         public static void UpdateRole(Role role)
         {
             using (SMSContext db = new SMSContext())
             {
                 var objrole = db.Roles.Single(x => x.Id == role.Id);
                 objrole.RoleName = role.RoleName;
                 db.SaveChanges();
             }
         }
         public static void UpdateUser(User user)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempUser = db.Users.Single(x => x.Id == user.Id);
                 tempUser.FirstName = user.FirstName;
                 tempUser.LastName = user.LastName;
                 tempUser.Password = user.Password;
                 tempUser.EmailAddress = user.EmailAddress;
                 tempUser.Phone1 = user.Phone1;
                 tempUser.Phone2 = user.Phone2;
                 db.SaveChanges();
             }
         }
        #endregion
        #region Delete
         public static void DeleteClass(int classId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempClass = db.Classes.Single(x => x.Id == classId);
                 db.Classes.Remove(tempClass);
                 db.SaveChanges();
             }
         }
         public static void DeleteSection(int sectionId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSection = db.Sections.Single(x => x.Id == sectionId);
                 db.Sections.Remove(tempSection);
                 db.SaveChanges();
             }
            
         }
         public static void DeleteGrade(int gradeId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempGrade = db.Grades.Single(x => x.Id == gradeId);
                 db.Grades.Remove(tempGrade);
                 db.SaveChanges();
             }
         }
         public static void DeleteModule(int moduleId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempModules = db.Modules.Single(x => x.Id == moduleId);
                 db.Modules.Remove(tempModules);
                 db.SaveChanges();
             }
         }
         public static void DeleteSession(int sessionId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSession = db.Sessions.Single(x => x.Id == sessionId);
                 db.Sessions.Remove(tempSession);
                 db.SaveChanges();
             }
         }
         public static void DeleteSubject(int subjectId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSubject = db.Subjects.Single(x => x.Id == subjectId);
                 db.Subjects.Remove(tempSubject);
                 db.SaveChanges();
             }
         }
         public static void DeleteSystemItem(int systemItemId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItemId);
                 db.SystemItems.Remove(tempSystemItem);
                 db.SaveChanges();
             }
         }
         public static void DeleteUser(int userId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempUser = db.Users.Single(x => x.Id == userId);
                 db.Users.Remove(tempUser);
                 db.SaveChanges();
             }
         }
         public static void DeleteRole(int roleId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempRole = db.Roles.Single(x => x.Id == roleId);
                 db.Roles.Remove(tempRole);
                 db.SaveChanges();
             }
         }

        #endregion   
    }
}