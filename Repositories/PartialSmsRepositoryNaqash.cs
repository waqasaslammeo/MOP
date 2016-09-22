
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.SessionState;
using BusinessEntity.SMS;
using BusinessEntity.Context;
using Utility;

namespace Repositories
{
    public static class PartialSmsRepositoryNaqash
    {
        #region Get
        public static Class GetClassById(int classId)
        {
            var classobj = new Class();

            try
            {
                using (var db = new SMSContext())
                {
                    classobj = db.Classes.Single(x => x.Id == classId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return classobj;
        }
        public static Section GetSectionById(int sectionId)
        {
            var section = new Section();
            try
            {
                using (var db = new SMSContext())
                {
                    section = db.Sections.Single(x => x.Id == sectionId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return section;
        }
        public static Grade GetGradeById(int gradeId)
        {
            var grade = new Grade();
            try
            {
                using (var db = new SMSContext())
                {
                    grade = db.Grades.Single(x => x.Id == gradeId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return grade;

        }
        public static Module GetModuleById(int moduleId)
        {
            var moduleobj = new Module();

            try
            {
                using (var db = new SMSContext())
                {
                    moduleobj = db.Modules.Single(x => x.Id == moduleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return moduleobj;
        }
        public static Session GetSessionById(int sessionId)
        {
            var sessionObj = new Session();

            try
            {
                using (var db = new SMSContext())
                {
                    sessionObj = db.Sessions.Single(x => x.Id == sessionId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return sessionObj;
        }
        public static Subject GetSubjectById(int subjectId)
        {
            var subjectObj = new Subject();

            try
            {
                using (var db = new SMSContext())
                {
                    subjectObj = db.Subjects.Single(x => x.Id == subjectId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return subjectObj;
        }
        public static SystemItem GetSystemItemById(int systemId)
        {
            var systemItemObj = new SystemItem();

            try
            {
                using (var db = new SMSContext())
                {
                    systemItemObj = db.SystemItems.Single(x => x.Id == systemId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return systemItemObj;
        }
        public static User GetUserById(int userId)
        {
            var userObj = new User();

            try
            {
                using (var db = new SMSContext())
                {
                    userObj = db.Users.Single(x => x.Id == userId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return userObj;
        }
        public static User GetUserValidate(string username,string password)
        {
            var user = new User();
            try
            {
                using (var db = new SMSContext())
                {
                    user = db.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();

                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

            return user;
        }
        public static Role GetRoleById(int roleId)
        {
            var roleobj = new Role();
            try
            {
                using (var db = new SMSContext())
                {
                    roleobj = db.Roles.Single(x => x.Id == roleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleobj;
        }
        public static SystemLog GetSystemLogById(int systemLogId)
        {
            var systemLog = new SystemLog();
            try
            {
                using (var db = new SMSContext())
                {
                    systemLog = db.SystemLogs.Single(x => x.Id == systemLogId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return systemLog;
        }
        public static UserRole GetIdByUserRole(int userRoleId)
        {
            var userRoleObj = new UserRole();
            try
            {
                using (var db = new SMSContext())
                {
                    userRoleObj = db.UserRoles.Single(x => x.Id == userRoleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return userRoleObj;
        }
        public static RoleItem GetIdByRoleItem(int roleItemId)
        {
            var roleItemObj = new RoleItem();
            try
            {
                using (var db = new SMSContext())
                {
                    roleItemObj = db.RoleItems.Single(x => x.Id == roleItemId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleItemObj;
        }
        #endregion

        #region List
        public static List<Class> GetAllClasses()
        {
            var classList = new List<Class>();

            try
            {
                using (var db = new SMSContext())
                {
                    classList = db.Classes.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

            return classList;
        }
        public static List<Section> GetAllSections()
        {
            var sectionList = new List<Section>();
            try
            {
                using (var db = new SMSContext())
                {
                    sectionList = db.Sections.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return sectionList;
        }
        public static List<Grade> GetAllGrades()
        {
            var gradeList = new List<Grade>();
            try
            {
                using (var db = new SMSContext())
                {
                    gradeList = db.Grades.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return gradeList;
        }
        public static List<SystemLog> GetAllSystemLog()
        {
            var systemLogList = new List<SystemLog>();
            try
            {
                using (var db = new SMSContext())
                {
                    systemLogList = db.SystemLogs.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return systemLogList;
        }
        public static List<Module> GetAllModule()
        {
            var moduleList = new List<Module>();
            try
            {
                using (var db = new SMSContext())
                {
                    moduleList = db.Modules.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return moduleList;
        }
        public static List<Session> GetAllSession()
        {
            var sessionList = new List<Session>();
            try
            {
                using (var db = new SMSContext())
                {
                    sessionList = db.Sessions.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return sessionList;
        }
        public static List<Subject> GetAllSubject()
        {
            var subjectList = new List<Subject>();
            try
            {
                using (var db = new SMSContext())
                {
                    subjectList = db.Subjects.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return subjectList;
        }
        public static List<SystemItem> GetAllSystemItem()
        {
            var systemItemList = new List<SystemItem>();
            try
            {
                using (var db = new SMSContext())
                {
                    systemItemList = db.SystemItems.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return systemItemList;
        }
        public static List<User> GetAllUser()
        {
            var userList = new List<User>();
            try
            {
                using (var db = new SMSContext())
                {
                    userList = db.Users.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return userList;
        }
        public static List<Role> GetAllRoles()
        {
            var roleList = new List<Role>();
            try
            {
               using (var db = new SMSContext())
                {
                    roleList = db.Roles.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleList;
        }
        public static List<UserRole> GetAllUserRoles()
        {
            var userRoleList = new List<UserRole>();
            try
            {
                using (var db = new SMSContext())
                {
                    userRoleList = db.UserRoles.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return userRoleList;
        }
        public static List<RoleItem> GetAllRoleItems()
        {
            var roleItemList = new List<RoleItem>();
            try
            {
                using (var db = new SMSContext())
                {
                    roleItemList = db.RoleItems.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleItemList;
        }

        #endregion
        #region Insert
        public static void InsertSystemLog(SystemLog systemLog)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.SystemLogs.Add(systemLog);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }
         public static void InsertClass(Class classObj)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Classes.Add(classObj);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertSection(Section section)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Sections.Add(section);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertGrade(Grade grade)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Grades.Add(grade);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertModule(Module module)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Modules.Add(module);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertSessions(Session session)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Sessions.Add(session);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertSubjects(Subject subject)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Subjects.Add(subject);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertSystemItem(SystemItem systemItem)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.SystemItems.Add(systemItem);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertUser(User user)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Users.Add(user);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertRole(Role role)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.Roles.Add(role);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertUserRole(UserRole userRole)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.UserRoles.Add(userRole);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void InsertRoleItem(RoleItem roleItem)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     db.RoleItems.Add(roleItem);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
        #endregion

        #region Update
         public static void UpdateClass(Class classObj)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempClass = db.Classes.Single(x => x.Id == classObj.Id);
                     tempClass.ClassName = classObj.ClassName;
                     tempClass.GradeId = classObj.GradeId;
                     tempClass.Grade = classObj.Grade;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateSection(Section section)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSection = db.Sections.Single(x => x.Id == section.Id);
                     tempSection.SectionName = section.SectionName;
                     tempSection.ClassId = section.ClassId;
                     tempSection.Class = section.Class;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateGrade(Grade grade)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempGrade = db.Grades.Single(x => x.Id == grade.Id);
                     tempGrade.Grades = grade.Grades;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateModule(Module module)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempModule = db.Modules.Single(x => x.Id == module.Id);
                     tempModule.ModuleName = module.ModuleName;
                     tempModule.Subject = module.Subject;
                     tempModule.SubjectId = module.SubjectId;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateSession(Session session)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSession = db.Sessions.Single(x => x.Id == session.Id);
                     tempSession.SessionName = session.SessionName;
                     tempSession.IsCurrent = session.IsCurrent;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateSubject(Subject subject)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSubject = db.Subjects.Single(x => x.Id == subject.Id);
                     tempSubject.SubjectName = subject.SubjectName;
                     tempSubject.Abbreviation = subject.Abbreviation;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateSystemItem(SystemItem systemItem)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItem.Id);
                     tempSystemItem.SystemItemName = systemItem.SystemItemName;
                     tempSystemItem.IsActive = systemItem.IsActive;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateRole(Role role)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var objrole = db.Roles.Single(x => x.Id == role.Id);
                     objrole.RoleName = role.RoleName;
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateUser(User user)
         {
             try
             {
                 using (var db = new SMSContext())
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
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateUserRole(UserRole userRole)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var objUserRole = db.UserRoles.Single(x => x.Id == userRole.Id);
                     objUserRole.UserId = userRole.UserId;
                     objUserRole.User = userRole.User;
                     objUserRole.RoleId = userRole.RoleId;
                     objUserRole.Role = userRole.Role;
                     db.SaveChanges();
                 }

             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateRoleItem(RoleItem roleItem)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var objRoleitem = db.RoleItems.Single(x => x.Id == roleItem.Id);
                     objRoleitem.RoleId = roleItem.RoleId;
                     objRoleitem.Role = roleItem.Role;
                     objRoleitem.ItemId = roleItem.ItemId;
                     objRoleitem.Item = roleItem.Item;
                     db.SaveChanges();
                 }

             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void UpdateSystemLog(SystemLog systemLog)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var obj = db.SystemLogs.Where(x => x.Id == systemLog.Id).SingleOrDefault();

                     obj.Date = systemLog.Date;
                     obj.Event = systemLog.Event;
                     obj.Time = systemLog.Time;
                     obj.LoggedInUser = systemLog.LoggedInUser;
                     db.SaveChanges();
                 }

             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
        #endregion

        #region Delete
         public static void DeleteClass(int classId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempClass = db.Classes.Single(x => x.Id == classId);
                     db.Classes.Remove(tempClass);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteSection(int sectionId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSection = db.Sections.Single(x => x.Id == sectionId);
                     db.Sections.Remove(tempSection);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
            
         }
         public static void DeleteGrade(int gradeId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempGrade = db.Grades.Single(x => x.Id == gradeId);
                     db.Grades.Remove(tempGrade);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteModule(int moduleId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempModules = db.Modules.Single(x => x.Id == moduleId);
                     db.Modules.Remove(tempModules);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteSession(int sessionId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSession = db.Sessions.Single(x => x.Id == sessionId);
                     db.Sessions.Remove(tempSession);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteSubject(int subjectId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSubject = db.Subjects.Single(x => x.Id == subjectId);
                     db.Subjects.Remove(tempSubject);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteSystemItem(int systemItemId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItemId);
                     db.SystemItems.Remove(tempSystemItem);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteUser(int userId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempUser = db.Users.Single(x => x.Id == userId);
                     db.Users.Remove(tempUser);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteRole(int roleId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempRole = db.Roles.Single(x => x.Id == roleId);
                     db.Roles.Remove(tempRole);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteUserRole(int userRoleId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempUserRole = db.UserRoles.Single(x => x.Id == userRoleId);
                     db.UserRoles.Remove(tempUserRole);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteRoleItem(int roleItemId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {
                     var tempRoleItem = db.RoleItems.Single(x => x.Id == roleItemId);
                     db.RoleItems.Remove(tempRoleItem);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
         public static void DeleteSystemLog(int systemLogId)
         {
             try
             {
                 using (var db = new SMSContext())
                 {

                     var obj = db.SystemLogs.Where(x => x.Id == systemLogId).FirstOrDefault();

                     db.SystemLogs.Remove(obj);
                     db.SaveChanges();
                 }
             }
             catch (Exception exception)
             {
                 LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
             } 
         }
        #endregion   
    }
}