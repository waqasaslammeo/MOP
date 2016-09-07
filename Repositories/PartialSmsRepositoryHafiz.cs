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

        #endregion

        #region GetById
		 public static Role GetRoleById(int roleId)
         {
             Role roleobj = new Role();
             using (SMSContext db = new SMSContext())
             {
                 roleobj = db.Roles.Single(x => x.Id == roleId);
             }
             return roleobj;
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

    }

}