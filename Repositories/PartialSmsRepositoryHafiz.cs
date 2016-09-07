using BusinessEntity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;

namespace Repositories
{
    public static class PartialSmsRepositoryHafiz
    {
        #region Insert


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


        #endregion

        #region GetById

	#endregion

         #region List

         #endregion

    }

}