using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;
using BusinessEntity.Context;

namespace Repositories
{
    public class PartialSmsRepositoryUsama
    {
        #region Insert

        public static void InsertSystemLog(SystemLog systemLog)
        {
            using (SMSContext db = new SMSContext())
            {
                db.SystemLogs.Add(systemLog);
                db.SaveChanges();
            }
        }
        #endregion

        #region Update
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
        
        #region Delete
        public static void DeleteSystemLog(int id)
        {
            using (SMSContext db = new SMSContext())
            {

                var obj = db.SystemLogs.Where(x => x.Id == id).FirstOrDefault();

                db.SystemLogs.Remove(obj);
                db.SaveChanges();
            }
        }
        #endregion
        
        #region GetById

        public static SystemLog GetSystemLogById(int systemLogId)
        {
         SystemLog systemLog= new SystemLog();
            using (SMSContext db = new SMSContext())
             {
                 systemLog = db.SystemLogs.Single(x => x.Id == systemLogId);
             }
             return systemLog;
        }

        #endregion

        #region List

        public static List<SystemLog> GetAllSystemLog()
        { 
            var systemLogList= new List<SystemLog>();
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
        #endregion

    }
}