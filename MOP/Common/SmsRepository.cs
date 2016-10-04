using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MOP.Context;
using MOP.Models.SMS;

namespace MOP.Common
{
    public static class SmsRepository
    {
        #region Get
        public static Student GetStudentById(int studentId)
        {
            var student = new Student();
            try
            {
                using (var db = new AlphaContext())
                {
                    student = db.Students.Single(x => x.Id == studentId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetStudentById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return student;
        }
        //public static StudentEnrollment GetStudentEnrollmentById(int studentEntrollmentId)
        //{
        //    var studentEnrollment = new StudentEnrollment();
        //    try
        //    {
        //        using (var db = new AlphaContext())
        //        {
        //            studentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEntrollmentId);
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        LogManage.Log("MethodName:GetStudentEnrollmentById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
        //    }
        //    return studentEnrollment;
        //}
        public static Student GetStudentByFatherName(string fatherName)
        {
            var student = new Student();
            try
            {
                using (var db = new AlphaContext())
                {
                    student = db.Students.Single(x => x.FatherName == fatherName);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetStudentByFatherName " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return student;
        }
        public static Student GetStudentByFatherCnic(string fatherCnic)
        {
            var student = new Student();
            try
            {
                using (var db = new AlphaContext())
                {
                    student = db.Students.Single(x => x.FatherCNIC == fatherCnic);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetStudentByFatherCnic " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return student;
        }
        public static Student GetStudentByGuardianCnic(string gardianCnic)
        {
            var student = new Student();
            try
            {
                using (var db = new AlphaContext())
                {
                    student = db.Students.Single(x => x.GuardianCNIC == gardianCnic);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetStudentByGuardianCnic " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return student;
        }
        public static Student GetStudentByEmailAddress(string emailAddress)
        {
            var student = new Student();
            try
            {
                using (var db = new AlphaContext())
                {
                    student = db.Students.Single(x => x.EmailAddress == emailAddress);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetStudentByEmailAddress " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return student;
        }
        public static PreviousSchool GetPreviousSchoolByStudentId(int studentId)
        {
            var previousSchoolStudentId = new PreviousSchool();
            try
            {
                using (var db = new AlphaContext())
                {
                    previousSchoolStudentId = db.PreviousSchools.Single(x => x.Id == studentId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetPreviousSchoolByStudentId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return previousSchoolStudentId;
        }
        public static Company GetCompanyById(int companyId)
        {
            var companyObj = new Company();
            try
            {
                using (var db = new AlphaContext())
                {
                    companyObj = db.Companies.Single(x => x.Id == companyId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetCompany " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return companyObj;
        }
        public static PhoneDirectory GetPhoneDirectory(int phoneDirectoryId)
        {
            var phoneDirectoryObj = new PhoneDirectory();
            try
            {
                using (var db = new AlphaContext())
                {
                    phoneDirectoryObj = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetPhoneDirectory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return phoneDirectoryObj;
        }
        //public static PhoneDirectoryDetail GetPhoneDirectoryDetail(int phoneDirectoryDetailId)
        //{
        //    var phoneDirectoryDetailObj = new PhoneDirectoryDetail();
        //    try
        //    {
        //        using (var db = new AlphaContext())
        //        {
        //            phoneDirectoryDetailObj = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetailId);
        //        }
        //    }
        //    catch (Exception exception)
        //    {

        //        LogManage.Log("MethodName:GetPhoneDirectory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
        //    }
        //    return phoneDirectoryDetailObj;
        //}
        public static City GetCityById(int cityId)
        {
            var cityObj = new City();
            try
            {
                using (var db = new AlphaContext())
                {
                    cityObj = db.Cities.Single(x => x.Id == cityId);
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetCity " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return cityObj;
        }
        public static Branch GetBranchById(int branchId)
        {
            var branchObj = new Branch();
            using (var db = new AlphaContext())
            {
                branchObj = db.Branches.Single(x => x.Id == branchId);
            }
            return branchObj;
        }
        public static Branch GetBranchByCityId(int cityId)
        {
            var branchByCityIdObj = new Branch();
            try
            {
                using (var db = new AlphaContext())
                {
                    branchByCityIdObj = db.Branches.Single(x => x.CityId == cityId);
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetBranchByCityId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return branchByCityIdObj;
        }
        public static Class GetClassById(int classId)
        {
            var classobj = new Class();

            try
            {
                using (var db = new AlphaContext())
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
                using (var db = new AlphaContext())
                {
                    section = db.Sections.Single(x => x.Id == sectionId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSectionById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return section;
        }
        public static Grade GetGradeById(int gradeId)
        {
            var grade = new Grade();
            try
            {
                using (var db = new AlphaContext())
                {
                    grade = db.Grades.Single(x => x.Id == gradeId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetGradeById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return grade;

        }
        public static Module GetModuleById(int moduleId)
        {
            var moduleobj = new Module();

            try
            {
                using (var db = new AlphaContext())
                {
                    moduleobj = db.Modules.Single(x => x.Id == moduleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetModuleById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return moduleobj;
        }
        public static Session GetSessionById(int sessionId)
        {
            var sessionObj = new Session();

            try
            {
                using (var db = new AlphaContext())
                {
                    sessionObj = db.Sessions.Single(x => x.Id == sessionId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSessionById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return sessionObj;
        }
        public static Subject GetSubjectById(int subjectId)
        {
            var subjectObj = new Subject();

            try
            {
                using (var db = new AlphaContext())
                {
                    subjectObj = db.Subjects.Single(x => x.Id == subjectId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSubjectById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return subjectObj;
        }
        public static SystemItem GetSystemItemById(int systemId)
        {
            var systemItemObj = new SystemItem();

            try
            {
                using (var db = new AlphaContext())
                {
                    systemItemObj = db.SystemItems.Single(x => x.Id == systemId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSystemItemById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return systemItemObj;
        }
        public static User GetUserById(int userId)
        {
            var userObj = new User();

            try
            {
                using (var db = new AlphaContext())
                {
                    userObj = db.Users.Single(x => x.Id == userId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetUserById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return userObj;
        }
        public static User GetUserValidate(string username, string password)
        {
            var user = new User();
            try
            {
                using (var db = new AlphaContext())
                {
                    user = db.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();

                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetUserValidate " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

            return user;
        }
        public static Role GetRoleById(int roleId)
        {
            var roleobj = new Role();
            try
            {
                using (var db = new AlphaContext())
                {
                    roleobj = db.Roles.Single(x => x.Id == roleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetRoleById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return roleobj;
        }
        public static SystemLog GetSystemLogById(int systemLogId)
        {
            var systemLog = new SystemLog();
            try
            {
                using (var db = new AlphaContext())
                {
                    systemLog = db.SystemLogs.Single(x => x.Id == systemLogId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetSystemLogById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return systemLog;
        }
        public static UserRole GetIdByUserRole(int userRoleId)
        {
            var userRoleObj = new UserRole();
            try
            {
                using (var db = new AlphaContext())
                {
                    userRoleObj = db.UserRoles.Single(x => x.Id == userRoleId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetIdByUserRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return userRoleObj;
        }
        public static RoleItem GetIdByRoleItem(int roleItemId)
        {
            var roleItemObj = new RoleItem();
            try
            {
                using (var db = new AlphaContext())
                {
                    roleItemObj = db.RoleItems.Single(x => x.Id == roleItemId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetIdByRoleItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return roleItemObj;
        }
        #endregion

        #region List
        public static List<Student> GetAllStudents()
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new AlphaContext())
                {
                    studentList = db.Students.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllStudents " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return studentList;
        }

        //public static List<StudentEnrollment> GetAllStudentEnrollments()
        //{
        //    var studentEnrollmentList = new List<StudentEnrollment>();
        //    try
        //    {
        //        using (var db = new AlphaContext())
        //        {
        //            studentEnrollmentList = db.StudentEnrollments.ToList();
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        LogManage.Log("MethodName:GetAllStudentEnrollments " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
        //    }
        //    return studentEnrollmentList;
        //}  
        public static List<Student> GetAllStudentByFatherCnic(string fatherCnic)
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new AlphaContext())
                {
                    studentList = db.Students.Where(x => x.FatherCNIC == fatherCnic).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllStudentByFatherCnic " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return studentList;
        }
        public static List<Student> GetAllStudentByFatherName(string fatherName)
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new AlphaContext())
                {
                    studentList = db.Students.Where(x => x.FatherName == fatherName).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllStudentByFatherName " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return studentList;
        }
        public static List<PreviousSchool> GetAllPreviousSchools()
        {
            var previousSchool = new List<PreviousSchool>();
            try
            {
                using (var db = new AlphaContext())
                {
                    previousSchool = db.PreviousSchools.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllPreviousSchools " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return previousSchool;
        }
        public static List<PreviousSchool> GetAllStudentsByInstituteName(string instituteName)
        {
            var studentByInstituteList = new List<PreviousSchool>();
            try
            {
                using (var db = new AlphaContext())
                {
                    studentByInstituteList = db.PreviousSchools.Where(x => x.InstituteName == instituteName).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllStudentsByInstituteName " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return studentByInstituteList;
        }
        public static List<PhoneDirectory> GetListPhoneDirectories()
        {
            var phoneDirectoryList = new List<PhoneDirectory>();
            try
            {
                using (var db = new AlphaContext())
                {
                    phoneDirectoryList = db.PhoneDirectories.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetListPhoneDirectories " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return phoneDirectoryList;
        }
        public static List<PhoneDirectoryDetail> GetListPhoneDirectoryDetails()
        {
            var phoneDirectoryDetailList = new List<PhoneDirectoryDetail>();
            try
            {
                using (var db = new AlphaContext())
                {
                    phoneDirectoryDetailList = db.PhoneDirectoryDetails.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetListPhoneDirectoryDetails " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return phoneDirectoryDetailList;
        }
        public static List<City> GetListCities()
        {
            var cityList = new List<City>();
            try
            {
                using (var db = new AlphaContext())
                {
                    cityList = db.Cities.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetListCities " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return cityList;
        }
        public static List<Branch> GetListBranches()
        {
            var branchObj = new List<Branch>();
            try
            {
                using (var db = new AlphaContext())
                {
                    branchObj = db.Branches.ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetListBranches " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return branchObj;
        }
        public static List<Branch> GetListBranchesByCityId(int cityId)
        {
            var branchObj = new List<Branch>();
            try
            {
                using (var db = new AlphaContext())
                {
                    branchObj = db.Branches.Where(x => x.CityId == cityId).ToList();
                }

            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:GetListBranchesByCityId " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return branchObj;
        }
        public static List<Class> GetAllClasses()
        {
            var classList = new List<Class>();

            try
            {
                using (var db = new AlphaContext())
                {
                    classList = db.Classes.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllClasses " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

            return classList;
        }
        public static List<Section> GetAllSections()
        {
            var sectionList = new List<Section>();
            try
            {
                using (var db = new AlphaContext())
                {
                    sectionList = db.Sections.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSections " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return sectionList;
        }
        public static List<Grade> GetAllGrades()
        {
            var gradeList = new List<Grade>();
            try
            {
                using (var db = new AlphaContext())
                {
                    gradeList = db.Grades.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllGrades " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return gradeList;
        }
        public static List<SystemLog> GetAllSystemLog()
        {
            var systemLogList = new List<SystemLog>();
            try
            {
                using (var db = new AlphaContext())
                {
                    systemLogList = db.SystemLogs.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSystemLog " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return systemLogList;
        }
        public static List<Module> GetAllModule()
        {
            var moduleList = new List<Module>();
            try
            {
                using (var db = new AlphaContext())
                {
                    moduleList = db.Modules.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllModule " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return moduleList;
        }
        public static List<Session> GetAllSession()
        {
            var sessionList = new List<Session>();
            try
            {
                using (var db = new AlphaContext())
                {
                    sessionList = db.Sessions.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSession " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return sessionList;
        }
        public static List<Subject> GetAllSubject()
        {
            var subjectList = new List<Subject>();
            try
            {
                using (var db = new AlphaContext())
                {
                    subjectList = db.Subjects.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSubject " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return subjectList;
        }
        public static List<SystemItem> GetAllSystemItem()
        {
            var systemItemList = new List<SystemItem>();
            try
            {
                using (var db = new AlphaContext())
                {
                    systemItemList = db.SystemItems.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllSystemItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return systemItemList;
        }
        public static List<User> GetAllUser()
        {
            var userList = new List<User>();
            try
            {
                using (var db = new AlphaContext())
                {
                    userList = db.Users.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllUser " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return userList;
        }
        public static List<Role> GetAllRoles()
        {
            var roleList = new List<Role>();
            try
            {
                using (var db = new AlphaContext())
                {
                    roleList = db.Roles.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllRoles " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return roleList;
        }
        public static List<UserRole> GetAllUserRoles()
        {
            var userRoleList = new List<UserRole>();
            try
            {
                using (var db = new AlphaContext())
                {
                    userRoleList = db.UserRoles.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllUserRoles " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return userRoleList;
        }
        public static List<RoleItem> GetAllRoleItems()
        {
            var roleItemList = new List<RoleItem>();
            try
            {
                using (var db = new AlphaContext())
                {
                    roleItemList = db.RoleItems.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetAllRoleItems " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
            return roleItemList;
        }

        #endregion

        #region Insert

        public static void InsertStudent(Student student)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertStudent " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.StudentEnrollments.Add(studentEnrollment);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertStudentEnrollment " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertBranch(Branch branch)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Branches.Add(branch);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertBranch " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertPreviousSchool(PreviousSchool previousSchool)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.PreviousSchools.Add(previousSchool);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertPreviousSchool " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertCompany(Company company)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Companies.Add(company);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:InsertCompany " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

        }
        public static void InsertPhoneDirectory(PhoneDirectory phoneDirectory)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.PhoneDirectories.Add(phoneDirectory);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:InsertPhoneDirectory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertPhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.PhoneDirectoryDetails.Add(phoneDirectoryDetail);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:InsertPhoneDirectoryDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

        }
        public static void InsertCity(City city)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Cities.Add(city);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:InsertCity " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

        }
        public static void InsertSystemLog(SystemLog systemLog)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.SystemLogs.Add(systemLog);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSystemLog " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertClass(Class classObj)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Classes.Add(classObj);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertClass " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertSection(Section section)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Sections.Add(section);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSection " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertGrade(Grade grade)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Grades.Add(grade);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertGrade " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertModule(Module module)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Modules.Add(module);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertModule " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertSessions(Session session)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Sessions.Add(session);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSessions " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertSubjects(Subject subject)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Subjects.Add(subject);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSubjects " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertSystemItem(SystemItem systemItem)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.SystemItems.Add(systemItem);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertSystemItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertUser(User user)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertUser " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertRole(Role role)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.Roles.Add(role);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertUserRole(UserRole userRole)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.UserRoles.Add(userRole);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertUserRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void InsertRoleItem(RoleItem roleItem)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    db.RoleItems.Add(roleItem);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:InsertRoleItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion

        #region Update

        public static void UpdateStudent(Student student)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempStudent = db.Students.Single(x => x.Id == student.Id);
                    tempStudent.FirstName = student.FirstName;
                    tempStudent.LastName = student.LastName;
                    tempStudent.StudentRollNo = student.StudentRollNo;
                    tempStudent.FatherName = student.FatherName;
                    tempStudent.PreviousSchoolId = student.PreviousSchoolId;
                    tempStudent.StudentEnrollmentId = student.StudentEnrollmentId;
                    tempStudent.FatherCNIC = student.FatherCNIC;
                    tempStudent.PassportNo = student.PassportNo;
                    tempStudent.VisaStartDate = student.VisaStartDate;
                    tempStudent.VisaExpiryDate = student.VisaExpiryDate;
                    tempStudent.GuardianName = student.GuardianName;
                    tempStudent.GuardianCNIC = student.GuardianCNIC;
                    tempStudent.ContactNo1 = student.ContactNo1;
                    tempStudent.ContactNo2 = student.ContactNo2;
                    tempStudent.EmailAddress = student.EmailAddress;
                    tempStudent.Address1 = student.Address1;
                    tempStudent.Address2 = student.Address2;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateStudent " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempStudentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEnrollment.Id);
                    tempStudentEnrollment.StudentId = studentEnrollment.StudentId;
                    tempStudentEnrollment.SectionId = studentEnrollment.SectionId;
                    tempStudentEnrollment.SessionId = studentEnrollment.SessionId;
                    tempStudentEnrollment.EnrollmentDate = studentEnrollment.EnrollmentDate;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateStudentEnrollment " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdatePreviousSchool(PreviousSchool previousSchool)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPreviousSchool = db.PreviousSchools.Single(x => x.Id == previousSchool.Id);
                    tempPreviousSchool.StudentId = previousSchool.StudentId;
                    tempPreviousSchool.InstituteName = previousSchool.InstituteName;
                    tempPreviousSchool.JoinDate = previousSchool.JoinDate;
                    tempPreviousSchool.LeaveDate = previousSchool.LeaveDate;

                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdatePreviousSchool " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateCompany(Company company)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCompany = db.Companies.Single(x => x.Id == company.Id);
                    tempCompany.CompanyName = company.CompanyName;
                    tempCompany.Logo = company.Logo;
                    tempCompany.TagLine = company.TagLine;
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

                LogManage.Log("MethodName:UpdateCompany " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdatePhoneDirectory(PhoneDirectory phoneDirectory)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectory.Id);
                    tempPhoneDirectory.ContactPerson = phoneDirectory.ContactPerson;
                    tempPhoneDirectory.Description = phoneDirectory.Description;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:UpdatePhoneDirectory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdatePhoneDirectoryDetail(PhoneDirectoryDetail phoneDirectoryDetail)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetail.Id);
                    tempPhoneDirectoryDetail.PhoneDirectoryId = phoneDirectoryDetail.PhoneDirectoryId;
                    tempPhoneDirectoryDetail.PhoneNumber = phoneDirectoryDetail.PhoneNumber;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:UpdatePhoneDirectoryDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

        }
        public static void UpdateCity(City city)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCity = db.Cities.Single(x => x.Id == city.Id);
                    tempCity.CityName = city.CityName;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:UpdateCity " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateBranch(Branch branch)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempBranch = db.Branches.Single(x => x.Id == branch.Id);
                    tempBranch.BranchName = branch.BranchName;
                    tempBranch.CityId = branch.CityId;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:UpdateBranch " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateClass(Class classObj)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateClass " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSection(Section section)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateSection " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateGrade(Grade grade)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempGrade = db.Grades.Single(x => x.Id == grade.Id);
                    tempGrade.Grades = grade.Grades;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateGrade " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateModule(Module module)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateModule " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSession(Session session)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSession = db.Sessions.Single(x => x.Id == session.Id);
                    tempSession.SessionName = session.SessionName;
                    tempSession.IsCurrent = session.IsCurrent;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateSession " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSubject(Subject subject)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSubject = db.Subjects.Single(x => x.Id == subject.Id);
                    tempSubject.SubjectName = subject.SubjectName;
                    tempSubject.Abbreviation = subject.Abbreviation;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateSubject " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSystemItem(SystemItem systemItem)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItem.Id);
                    tempSystemItem.SystemItemName = systemItem.SystemItemName;
                    tempSystemItem.IsActive = systemItem.IsActive;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateSystemItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateRole(Role role)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var objrole = db.Roles.Single(x => x.Id == role.Id);
                    objrole.RoleName = role.RoleName;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:UpdateRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateUser(User user)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateUser " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateUserRole(UserRole userRole)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateUserRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateRoleItem(RoleItem roleItem)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateRoleItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void UpdateSystemLog(SystemLog systemLog)
        {
            try
            {
                using (var db = new AlphaContext())
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
                LogManage.Log("MethodName:UpdateSystemLog " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion

        #region Delete

        public static void DeleteStudent(int studentId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempStudent = db.Students.Single(x => x.Id == studentId);
                    db.Students.Remove(tempStudent);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteStudent " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        public static void DeleteStudentEnrollment(int studentEnrollmentId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempStudentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEnrollmentId);
                    db.StudentEnrollments.Remove(tempStudentEnrollment);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteStudentEnrollment " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        public static void DeletePreviousSchool(int previousSchoolId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPreviousSchcool = db.PreviousSchools.Single(x => x.Id == previousSchoolId);
                    db.PreviousSchools.Remove(tempPreviousSchcool);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeletePreviousSchool " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        public static void DeleteCompany(int companyId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCompany = db.Companies.Single(x => x.Id == companyId);
                    db.Companies.Remove(tempCompany);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:DeleteCompany " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeletePhoneDirectory(int phoneDirectoryId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPhoneDirectory = db.PhoneDirectories.Single(x => x.Id == phoneDirectoryId);
                    db.PhoneDirectories.Remove(tempPhoneDirectory);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:DeletePhoneDirectory " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeletePhoneDirectoryDetail(int phoneDirectoryDetailId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempPhoneDirectoryDetail = db.PhoneDirectoryDetails.Single(x => x.Id == phoneDirectoryDetailId);
                    db.PhoneDirectoryDetails.Remove(tempPhoneDirectoryDetail);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:DeletePhoneDirectoryDetail " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteCity(int cityId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempCity = db.Cities.Single(x => x.Id == cityId);
                    db.Cities.Remove(tempCity);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:DeleteCity " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteBranch(int branchId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempBranch = db.Branches.Single(x => x.Id == branchId);
                    db.Branches.Remove(tempBranch);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

                LogManage.Log("MethodName:DeleteBranch " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteClass(int classId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempClass = db.Classes.Single(x => x.Id == classId);
                    db.Classes.Remove(tempClass);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteClass " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSection(int sectionId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSection = db.Sections.Single(x => x.Id == sectionId);
                    db.Sections.Remove(tempSection);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSection " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }

        }
        public static void DeleteGrade(int gradeId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempGrade = db.Grades.Single(x => x.Id == gradeId);
                    db.Grades.Remove(tempGrade);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteGrade " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteModule(int moduleId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempModules = db.Modules.Single(x => x.Id == moduleId);
                    db.Modules.Remove(tempModules);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteModule " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSession(int sessionId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSession = db.Sessions.Single(x => x.Id == sessionId);
                    db.Sessions.Remove(tempSession);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSession " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSubject(int subjectId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSubject = db.Subjects.Single(x => x.Id == subjectId);
                    db.Subjects.Remove(tempSubject);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSubject " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSystemItem(int systemItemId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempSystemItem = db.SystemItems.Single(x => x.Id == systemItemId);
                    db.SystemItems.Remove(tempSystemItem);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSystemItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteUser(int userId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempUser = db.Users.Single(x => x.Id == userId);
                    db.Users.Remove(tempUser);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteUser " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteRole(int roleId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempRole = db.Roles.Single(x => x.Id == roleId);
                    db.Roles.Remove(tempRole);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteUserRole(int userRoleId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempUserRole = db.UserRoles.Single(x => x.Id == userRoleId);
                    db.UserRoles.Remove(tempUserRole);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteUserRole " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteRoleItem(int roleItemId)
        {
            try
            {
                using (var db = new AlphaContext())
                {
                    var tempRoleItem = db.RoleItems.Single(x => x.Id == roleItemId);
                    db.RoleItems.Remove(tempRoleItem);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteRoleItem " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        public static void DeleteSystemLog(int systemLogId)
        {
            try
            {
                using (var db = new AlphaContext())
                {

                    var obj = db.SystemLogs.Where(x => x.Id == systemLogId).FirstOrDefault();

                    db.SystemLogs.Remove(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:DeleteSystemLog " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }
        }
        #endregion   
    }
}