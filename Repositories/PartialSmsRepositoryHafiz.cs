using BusinessEntity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;
using Utility;


namespace Repositories
{
    public static class PartialSmsRepositoryHafiz
    {
        #region Insert

        public static void InsertCompany(Company company)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.Companies.Add(company);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message); 
            }
            
        }

        public static void InsertPhoneDirectory(PhoneDirectory phoneDirectory)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.PhoneDirectories.Add(phoneDirectory);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }

        public static void InsertPhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.PhoneDirectoryDetails.Add(phoneDirectoryDetail);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            
        }

        public static void InsertCity(City city)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.Cities.Add(city);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            
        }

        public static void InsertBranch(Branch branch)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.Branches.Add(branch);
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

        public static void UpdateCompany(Company company)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempCompany = db.Companies.Single(x => x.Id == company.Id);
                    tempCompany.CompanyName = company.CompanyName;
                    tempCompany.Logo = company.Logo;
                    tempCompany.TagLink = company.TagLink;
                    tempCompany.DetailDescription = company.DetailDescription;
                    tempCompany.ShortDescription = company.ShortDescription;
                    tempCompany.PhoneNumber = company.PhoneNumber;
                    tempCompany.FounderName = company.FounderName;
                    tempCompany.FoundedOn = company.FoundedOn;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void UpdatePhoneDirectory(PhoneDirectory phoneDirectory)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectory.Id);
                    tempPhoneDirectory.ContactPerson = phoneDirectory.ContactPerson;
                    tempPhoneDirectory.Description = phoneDirectory.Description;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void UpdatePhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetail.Id);
                    tempPhoneDirectoryDetail.PhoneDirectoryId = phoneDirectoryDetail.PhoneDirectoryId;
                    tempPhoneDirectoryDetail.PhoneNumber = phoneDirectoryDetail.PhoneNumber;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            
        }

        public static void UpdateCity(City city)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempCity = db.Cities.Single(x => x.Id == city.Id);
                    tempCity.CityName = city.CityName;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void UpdateBranch(Branch branch)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempBranch = db.Branches.Single(x => x.Id == branch.Id);
                    tempBranch.BranchName = branch.BranchName;
                    tempBranch.CityId = branch.CityId;
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

        public static void DeleteCompany(int companyId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempCompany = db.Companies.Single(x => x.Id == companyId);
                    db.Companies.Remove(tempCompany);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void DeletePhoneDirectory(int phoneDirectoryId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
                    db.PhoneDirectories.Remove(tempPhoneDirectory);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void DeletePhoneDirectoryDetail(int phoneDirectoryDetailId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetailId);
                    db.PhoneDirectoryDetails.Remove(tempPhoneDirectoryDetail);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void DeleteCity(int cityId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempCity = db.Cities.Single(x => x.Id == cityId);
                    db.Cities.Remove(tempCity);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void DeleteBranch(Branch branch)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempBranch = db.Branches.Single(x => x.Id == branch.Id);
                    db.Branches.Remove(tempBranch);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }
        #endregion

        #region Get

        public static Company GetCompany(int companyId)
        {
            var companyObj = new Company();
            try
            {
                using (var db = new SMSContext())
                {
                    companyObj = db.Companies.Single(x => x.Id == companyId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return companyObj;
        }

        public static PhoneDirectory GetPhoneDirectory(int phoneDirectoryId)
        {
            var phoneDirectoryObj = new PhoneDirectory();
            try
            {
                using (var db = new SMSContext())
                {
                    phoneDirectoryObj = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return phoneDirectoryObj;
        }

        public static City GetCity(int cityId)
        {
            var cityObj = new City();
            try
            {
                using (var db = new SMSContext())
                {
                    cityObj = db.Cities.Single(x => x.Id == cityId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return cityObj;
        }

        //public static Branch GetBranch(int branchId)
        //{
        //    var branchObj = new Branch();
        //    using (var db = new SMSContext())
        //    {
        //        branchObj = db.Branches.Single(x => x.Id == branchId);
        //    }
        //    return branchObj;
        //}

        public static Branch GetBranchByCityId(int cityId)
        {
            var branchByCityIdObj = new Branch();
            try
            {
                using (var db = new SMSContext())
                {
                    branchByCityIdObj = db.Branches.Single(x => x.CityId == cityId);
                }
                
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return branchByCityIdObj;
        }
	    #endregion

         #region List

        public static List<PhoneDirectory> GetListPhoneDirectories()
        {
            var phoneDirectoryList = new List<PhoneDirectory>();
            try
            {
                using (var db = new SMSContext())
                {
                    phoneDirectoryList = db.PhoneDirectories.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return phoneDirectoryList;
        }

        public static List<PhoneDirectoryDetail> GetListPhoneDirectoryDetails()
        {
            var phoneDirectoryDetailList = new List<PhoneDirectoryDetail>();
            try
            {
                using (var db = new SMSContext())
                {
                    phoneDirectoryDetailList = db.PhoneDirectoryDetails.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return phoneDirectoryDetailList;
        }

        public static List<City> GetListCities()
        {
            var cityList = new List<City>();
            try
            {
                using (var db = new SMSContext())
                {
                    cityList = db.Cities.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return cityList;
        }

        public static List<Branch> GetListBranches()
        {
            var branchObj = new List<Branch>();
            try
            {
                using (var db = new SMSContext())
                {
                    branchObj = db.Branches.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return branchObj;
        }

        public static List<Branch> GetListBranchesByCityId(int cityId)
        {
            var branchObj = new List<Branch>();
            try
            {
                using (var db = new SMSContext())
                {
                    branchObj = db.Branches.Where(x => x.CityId == cityId).ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return branchObj;
        }
         #endregion

    }

}