
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.SessionState;
using BusinessEntity.Context;
using BusinessEntity.SMS;


namespace Test2
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
               // LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
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
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleItemObj;
        }
        #endregion

        #region List

        public static List<Role> GetAllRoles( IContext db)
        {
            var roleList = new List<Role>();
            try
            {
               // using (var db = new SMSContext())
                {
                    roleList = db.Roles.ToList();
                }
            }
            catch (Exception exception)
            {
                //LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return roleList;
        }

        #endregion


    }
}