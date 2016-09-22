using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;
using BusinessEntity.Context;
using Utility;

namespace Repositories
{
    public class PartialSmsRepositoryUsama
    {
        #region Insert
        public static void InsertStudent(Student student)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void InsertPreviousSchool(PreviousSchool previousSchool)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.PreviousSchools.Add(previousSchool);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void InsertStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    db.StudentEnrollments.Add(studentEnrollment);
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
        public static void UpdateStudent(Student student)
        {
            try
            {
                using (var db = new SMSContext())
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
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void UpdateStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            try
            {
                using (var db = new SMSContext())
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
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
        }

        public static void UpdatePreviousSchool(PreviousSchool previousSchool)
        {
            try
            {
                using (var db = new SMSContext())
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
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            }  
        }
        #endregion
        
        #region Delete
        public static void DeleteStudent(int studentId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempStudent = db.Students.Single(x => x.Id == studentId);
                    db.Students.Remove(tempStudent);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        public static void DeleteStudentEnrollment(int studentEnrollmentId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempStudentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEnrollmentId);
                    db.StudentEnrollments.Remove(tempStudentEnrollment);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        public static void DeletePreviousSchool(int previousSchoolId)
        {
            try
            {
                using (var db = new SMSContext())
                {
                    var tempPreviousSchcool = db.PreviousSchools.Single(x => x.Id == previousSchoolId);
                    db.PreviousSchools.Remove(tempPreviousSchcool);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 

        }
        #endregion
        
        #region GetById
        public static Student GetStudentById(int studentId)
        {
            var student = new Student();
            try
            {
                using (var db = new SMSContext())
                {
                    student = db.Students.Single(x => x.Id == studentId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return student;
        }

        public static Student GetStudentByFatherName(string fatherName)
        {
            var student = new Student();
            try
            {
                using (var db = new SMSContext())
                {
                    student = db.Students.Single(x => x.FatherName == fatherName);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return student;
        }

        public static Student GetStudentByFatherCnic(string fatherCnic)
        {
            var student = new Student();
            try
            {
                using (var db = new SMSContext())
                {
                    student = db.Students.Single(x => x.FatherCNIC == fatherCnic);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return student;
        }

        public static Student GetStudentByGuardianCnic(string gardianCnic)
        {
            var student = new Student();
            try
            {
                using (var db = new SMSContext())
                {
                    student = db.Students.Single(x => x.GuardianCNIC == gardianCnic);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return student;
        }

        public static Student GetStudentByEmailAddress(string emailAddress)
        {
            var student = new Student();
            try
            {
                using (var db = new SMSContext())
                {
                    student = db.Students.Single(x => x.EmailAddress == emailAddress);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return student;
        }

        public static PreviousSchool GetPreviousSchoolByStudentId(int studentId)
        {
            var previousSchoolStudentId = new PreviousSchool();
            try
            {
                using (var db = new SMSContext())
                {
                    previousSchoolStudentId = db.PreviousSchools.Single(x => x.Id == studentId);
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return previousSchoolStudentId;
        }
        #endregion

        #region List
        public static List<Student> GetAllStudents()
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new SMSContext())
                {
                    studentList = db.Students.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return studentList;
        }

        public static List<Student> GetAllStudentByFatherCnic(string fatherCnic)
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new SMSContext())
                {
                    studentList = db.Students.Where(x => x.FatherCNIC == fatherCnic).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return studentList;
        }

        public static List<Student> GetAllStudentByFatherName(string fatherName)
        {
            var studentList = new List<Student>();
            try
            {
                using (var db = new SMSContext())
                {
                    studentList = db.Students.Where(x => x.FatherName == fatherName).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return studentList;
        }

        public static List<PreviousSchool> GetAllPreviousSchools()
        {
            var previousSchool = new List<PreviousSchool>();
            try
            {
                using (var db = new SMSContext())
                {
                    previousSchool = db.PreviousSchools.ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return previousSchool;
        }

        public static List<PreviousSchool> GetAllStudentsByInstituteName(string instituteName)
        {
            var studentByInstituteList = new List<PreviousSchool>();
            try
            {
                using (var db = new SMSContext())
                {
                    studentByInstituteList = db.PreviousSchools.Where(x => x.InstituteName == instituteName).ToList();
                }
            }
            catch (Exception exception)
            {
                LogManage.Log("MethodName:GetClassById " + Environment.NewLine + " Time: " + DateTime.Now + Environment.NewLine + " ErrorMsg: " + exception.Message);
            } 
            return studentByInstituteList;
        }
        #endregion

    }
}