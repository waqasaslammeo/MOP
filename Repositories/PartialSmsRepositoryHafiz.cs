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

        public static void InsertCompany(Company company)
        {
            using (SMSContext db = new SMSContext())
            {
                db.Companies.Add(company);
                db.SaveChanges();
            }
        }

        public static void InsertPhoneDirectory(PhoneDirectory phoneDirectory)
        {
            using (var db = new SMSContext())
            {
                db.PhoneDirectories.Add(phoneDirectory);
                db.SaveChanges();
            }
        }

        public static void InsertPhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            using (var db = new SMSContext())
            {
                db.PhoneDirectoryDetails.Add(phoneDirectoryDetail);
                db.SaveChanges();
            }
        }

        public static void InsertCity(City city)
        {
            using (var db = new SMSContext())
            {
                db.Cities.Add(city);
                db.SaveChanges();
            }
        }

        public static void InsertBranch(Branch branch)
        {
            using (var db = new SMSContext())
            {
                db.Branches.Add(branch);
                db.SaveChanges();
            }
        }
        #endregion
        #region Update

        public static void UpdateCompany(Company company)
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

        public static void UpdatePhoneDirectory(PhoneDirectory phoneDirectory)
        {
            using (var db = new SMSContext())
            {
                var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectory.Id);
                tempPhoneDirectory.ContactPerson = phoneDirectory.ContactPerson;
                tempPhoneDirectory.Description = phoneDirectory.Description;
                db.SaveChanges();
            }
        }

        public static void UpdatePhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            using (var db = new SMSContext())
            {
                var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetail.Id);
                tempPhoneDirectoryDetail.PhoneDirectoryId = phoneDirectoryDetail.PhoneDirectoryId;
                tempPhoneDirectoryDetail.PhoneNumber = phoneDirectoryDetail.PhoneNumber;
                db.SaveChanges();
            }
            
        }

        public static void UpdateCity(City city)
        {
            using (var db = new SMSContext())
            {
                var tempCity = db.Cities.Single(x => x.Id == city.Id);
                tempCity.CityName = city.CityName;
                db.SaveChanges();
            }
        }

        public static void UpdateBranch(Branch branch)
        {
            using (var db = new SMSContext())
            {
                var tempBranch = db.Branches.Single(x => x.Id == branch.Id);
                tempBranch.BranchName = branch.BranchName;
                tempBranch.CityId = branch.CityId;
                db.SaveChanges();
            } 
        }
        #endregion

        #region Delete

        public static void DeleteCompany(int companyId)
        {
            using (var db = new SMSContext())
            {
                var tempCompany = db.Companies.Single(x => x.Id == companyId);
                db.Companies.Remove(tempCompany);
                db.SaveChanges();
            }
        }

        public static void DeletePhoneDirectory(int phoneDirectoryId)
        {
            using (var db = new SMSContext())
            {
                var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
                db.PhoneDirectories.Remove(tempPhoneDirectory);
                db.SaveChanges();
            }
        }

        public static void DeletePhoneDirectoryDetail(int phoneDirectoryDetailId)
        {
            using (var db = new SMSContext())
            {
                var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetailId);
                db.PhoneDirectoryDetails.Remove(tempPhoneDirectoryDetail);
                db.SaveChanges();
            }
        }

        public static void DeleteCity(int cityId)
        {
            using (var db = new SMSContext())
            {
                var tempCity = db.Cities.Single(x => x.Id == cityId);
                db.Cities.Remove(tempCity);
                db.SaveChanges();
            }
        }

        public static void DeleteBranch(Branch branch)
        {
            using (var db = new SMSContext())
            {
                var tempBranch = db.Branches.Single(x => x.Id == branch.Id);
                db.Branches.Remove(tempBranch);
                db.SaveChanges();
            }
        }
        #endregion

        #region Get

        public static Company GetCompany(int companyId)
        {
            Company companyObj = new Company();
            using (var db = new SMSContext())
            {
                companyObj = db.Companies.Single(x => x.Id == companyId);
            }
            return companyObj;
        }

        public static PhoneDirectory GetPhoneDirectory(int phoneDirectoryId)
        {
            var phoneDirectoryObj = new PhoneDirectory();
            using (var db = new SMSContext())
            {
                phoneDirectoryObj = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
            }
            return phoneDirectoryObj;
        }

        public static City GetCity(int cityId)
        {
            var cityObj = new City();
            using (var db = new SMSContext())
            {
                cityObj = db.Cities.Single(x=>x.Id==cityId);
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
            using (var db = new SMSContext())
            {
                branchByCityIdObj = db.Branches.Single(x=>x.CityId==cityId);
            }
            return branchByCityIdObj;
        }
	    #endregion

         #region List

        public static List<PhoneDirectory> GetListPhoneDirectories()
        {
            var phoneDirectoryList = new List<PhoneDirectory>();
            using (var db = new SMSContext())
            {
                phoneDirectoryList = db.PhoneDirectories.ToList();
            }
            return phoneDirectoryList;
        }

        public static List<PhoneDirectoryDetail> GetListPhoneDirectoryDetails()
        {
            var phoneDirectoryDetailList = new List<PhoneDirectoryDetail>();
            using (var db = new SMSContext())
            {
                phoneDirectoryDetailList = db.PhoneDirectoryDetails.ToList();
            }
            return phoneDirectoryDetailList;
        }

        public static List<City> GetListCities()
        {
            var cityList = new List<City>();
            using (var db = new SMSContext())
            {
                cityList = db.Cities.ToList();
            }
            return cityList;
        }

        public static List<Branch> GetListBranches()
        {
            var branchObj = new List<Branch>();
            using (var db = new SMSContext())
            {
                branchObj = db.Branches.ToList();
            }
            return branchObj;
        }

        public static List<Branch> GetListBranchesByCityId(int cityId)
        {
            var branchObj = new List<Branch>();
            using (var db = new SMSContext())
            {
                branchObj = db.Branches.Where(x => x.CityId == cityId).ToList();
            }
            return branchObj;
        }
         #endregion

    }

}