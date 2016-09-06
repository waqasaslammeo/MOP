using BusinessEntity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;

namespace Repositories
{
    public static class PartialSmsRepository
    {
        #region Insert
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
        public static void UpdateRole(Role role)
        {
            using (SMSContext db = new SMSContext())
            {
                var objrole = db.Roles.Single(x => x.Id == role.Id);
                objrole.RoleName = role.RoleName;
                db.SaveChanges();
            }
        }
        #endregion

        #region Delete
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

        #region
        #endregion


    }






}