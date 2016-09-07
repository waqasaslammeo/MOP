using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BusinessEntity.SMS;
using BusinessEntity.Context;

namespace Repositories
{
     public static class PartialSmsRepositoryNaqash
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
        public static SystemLog GetSystemLogById(int systemLogId)
        {
            SystemLog systemLog = new SystemLog();
            using (SMSContext db = new SMSContext())
            {
                systemLog = db.SystemLogs.Single(x => x.Id == systemLogId);
            }
            return systemLog;
        }
        public static UserRole GetIdByUserRole(int userRoleId)
        {
            UserRole userRoleObj = new UserRole();
            using (SMSContext db = new SMSContext())
            {
                userRoleObj = db.UserRoles.Single(x => x.Id == userRoleId);
            }
            return userRoleObj;
        }
        public static RoleItem GetIdByRoleItem(int roleItemId)
        {
            RoleItem roleItemObj = new RoleItem();
            using (SMSContext db = new SMSContext())
            {
                roleItemObj = db.RoleItems.Single(x => x.Id == roleItemId);
            }
            return roleItemObj;
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
        public static List<SystemLog> GetAllSystemLog()
        {
            var systemLogList = new List<SystemLog>();
            using (SMSContext db = new SMSContext())
            {
                systemLogList = db.SystemLogs.ToList();
            }
            return systemLogList;
        }
        public static List<Module> GetAllModule()
        {
            var moduleList = new List<Module>();
            using (SMSContext db = new SMSContext())
            {
                moduleList = db.Modules.ToList();
            }
            return moduleList;
        }
        public static List<Session> GetAllSession()
        {
            var sessionList = new List<Session>();
            using (SMSContext db = new SMSContext())
            {
                sessionList = db.Sessions.ToList();
            }
            return sessionList;
        }
        public static List<Subject> GetAllSubject()
        {
            var subjectList = new List<Subject>();
            using (SMSContext db = new SMSContext())
            {
                subjectList = db.Subjects.ToList();
            }
            return subjectList;
        }
        public static List<SystemItem> GetAllSystemItem()
        {
            var systemItemList = new List<SystemItem>();
            using (SMSContext db = new SMSContext())
            {
                systemItemList = db.SystemItems.ToList();
            }
            return systemItemList;
        }
        public static List<User> GetAllUser()
        {
            var userList = new List<User>();
            using (SMSContext db = new SMSContext())
            {
                userList = db.Users.ToList();
            }
            return userList;
        }
        public static List<Role> GetAllRoles()
        {
            var roleList = new List<Role>();
            using (SMSContext db = new SMSContext())
            {
                roleList = db.Roles.ToList();
            }
            return roleList;
        }
        public static List<UserRole> GetAllUserRoles()
        {
            var userRoleList = new List<UserRole>();
            using (SMSContext db = new SMSContext())
            {
                userRoleList = db.UserRoles.ToList();
            }
            return userRoleList;
        }
        public static List<RoleItem> GetAllRoleItems()
        {
            var roleItemList = new List<RoleItem>();
            using (SMSContext db = new SMSContext())
            {
                roleItemList = db.RoleItems.ToList();
            }
            return roleItemList;
        }

        #endregion
        #region Insert
        public static void InsertSystemLog(SystemLog systemLog)
        {
            using (SMSContext db = new SMSContext())
            {
                db.SystemLogs.Add(systemLog);
                db.SaveChanges();
            }
        }
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
         public static void InsertUserRole(UserRole userRole)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.UserRoles.Add(userRole);
                 db.SaveChanges();
             }
         }
         public static void InsertRoleItem(RoleItem roleItem)
         {
             using (SMSContext db = new SMSContext())
             {
                 db.RoleItems.Add(roleItem);
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
         public static void UpdateUserRole(UserRole userRole)
         {
             using (SMSContext db = new SMSContext())
             {
                 var objUserRole = db.UserRoles.Single(x => x.Id == userRole.Id);
                 objUserRole.UserId = userRole.UserId;
                 objUserRole.User = userRole.User;
                 objUserRole.RoleId = userRole.RoleId;
                 objUserRole.Role = userRole.Role;
                 db.SaveChanges();
             }
         }
         public static void UpdateRoleItem(RoleItem roleItem)
         {
             using (SMSContext db = new SMSContext())
             {
                 var objRoleitem = db.RoleItems.Single(x => x.Id == roleItem.Id);
                 objRoleitem.RoleId = roleItem.RoleId;
                 objRoleitem.Role = roleItem.Role;
                 objRoleitem.ItemId = roleItem.ItemId;
                 objRoleitem.Item = roleItem.Item;
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
        

         public static void DeleteUserRole(int userRoleId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempUserRole = db.UserRoles.Single(x => x.Id == userRoleId);
                 db.UserRoles.Remove(tempUserRole);
                 db.SaveChanges();
             }
         }

         public static void DeleteRoleItem(int roleItemId)
         {
             using (SMSContext db = new SMSContext())
             {
                 var tempRoleItem = db.RoleItems.Single(x => x.Id == roleItemId);
                 db.RoleItems.Remove(tempRoleItem);
                 db.SaveChanges();
             }
         }
         public static void DeleteSystemLog(int id)
         {
             using (SMSContext db = new SMSContext())
             {

                 var obj = db.SystemLogs.Where(x => x.Id == id).FirstOrDefault();

                 db.SystemLogs.Remove(obj);
                 db.SaveChanges();
             }
         }

         public static void UpdateSystemLog(SystemLog systemLog)
         {
             using (SMSContext db = new SMSContext())
             {
                 var obj = db.SystemLogs.Where(x => x.Id == systemLog.Id).SingleOrDefault();

                 obj.Date = systemLog.Date;
                 obj.Event = systemLog.Event;
                 obj.Time = systemLog.Time;
                 obj.LoggedInUser = systemLog.LoggedInUser;

                 db.SaveChanges();
             }
         }

        #endregion   
    }
}