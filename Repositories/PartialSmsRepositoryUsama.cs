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
        public static void InsertStudent(Student student)
        {
            using (SMSContext db = new SMSContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public static void InsertPreviousSchool(PreviousSchool previousSchool)
        {
            using (SMSContext db = new SMSContext())
            {
                db.PreviousSchools.Add(previousSchool);
                db.SaveChanges();
            }
        }

        public static void InsertStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            using (SMSContext db = new SMSContext())
            {
                db.StudentEnrollments.Add(studentEnrollment);
                db.SaveChanges();
            }
        }
      
        #endregion

        #region Update
        public static void UpdateStudent(Student student)
        {
            using (SMSContext db = new SMSContext())
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

        public static void UpdateStudentEnrollment(StudentEnrollment studentEnrollment)
        {
            using (SMSContext db = new SMSContext())
            {
                var tempStudentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEnrollment.Id);
                tempStudentEnrollment.StudentId = studentEnrollment.StudentId;
                tempStudentEnrollment.SectionId = studentEnrollment.SectionId;
                tempStudentEnrollment.SessionId = studentEnrollment.SessionId;
                tempStudentEnrollment.EnrollmentDate = studentEnrollment.EnrollmentDate;
                db.SaveChanges();
            }
        }

        public static void UpdatePreviousSchool(PreviousSchool previousSchool)
        {
            using (SMSContext db = new SMSContext())
            {
                var tempPreviousSchool = db.PreviousSchools.Single(x => x.Id == previousSchool.Id);
                tempPreviousSchool.StudentId = previousSchool.StudentId;
                tempPreviousSchool.InstituteName = previousSchool.InstituteName;
                tempPreviousSchool.JoinDate = previousSchool.JoinDate;
                tempPreviousSchool.LeaveDate = previousSchool.LeaveDate;

            }
        }
        #endregion
        
        #region Delete
        public static void DeleteStudent(int studentId)
        {
            using (SMSContext db = new SMSContext())
            {
                var tempStudent = db.Students.Single(x => x.Id == studentId);
                db.Students.Remove(tempStudent);
                db.SaveChanges();
            }

        }

        public static void DeleteStudentEnrollment(int studentEnrollmentId)
        {
            using (SMSContext db = new SMSContext())
            {
                var tempStudentEnrollment = db.StudentEnrollments.Single(x => x.Id == studentEnrollmentId);
                db.StudentEnrollments.Remove(tempStudentEnrollment);
                db.SaveChanges();
            }

        }

        public static void DeletePreviousSchool(int previousSchoolId)
        {
            using (SMSContext db = new SMSContext())
            {
                var tempPreviousSchcool = db.PreviousSchools.Single(x => x.Id == previousSchoolId);
                db.PreviousSchools.Remove(tempPreviousSchcool);
                db.SaveChanges();
            }

        }
        #endregion
        
        #region GetById
        public static Student GetStudentById(int studentId)
        {
            var student = new Student();
            using (SMSContext db = new SMSContext())
            {
                student = db.Students.Single(x => x.Id == studentId);
            }
            return student;
        }

        public static Student GetStudentByFatherName(string fatherName)
        {
            var student = new Student();
            using (SMSContext db = new SMSContext())
            {
                student = db.Students.Single(x => x.FatherName == fatherName);
            }
            return student;
        }

        public static Student GetStudentByFatherCNIC(string cnic)
        {
            var student = new Student();
            using (SMSContext db = new SMSContext())
            {
                student = db.Students.Single(x => x.FatherCNIC == cnic);
            }
            return student;
        }

        public static Student GetStudentByGuardianCNIC(string cnic)
        {
            var student = new Student();
            using (SMSContext db = new SMSContext())
            {
                student = db.Students.Single(x => x.GuardianCNIC == cnic);
            }
            return student;
        }

        public static Student GetStudentByEmailAddress(string emailAddress)
        {
            var student = new Student();
            using (SMSContext db = new SMSContext())
            {
                student = db.Students.Single(x => x.EmailAddress == emailAddress);
            }
            return student;
        }

        public static PreviousSchool GetPreviousSchoolByStudentId(int studentId)
        {
            var previousSchoolStudentId = new PreviousSchool();
            using (SMSContext db = new SMSContext())
            {
                previousSchoolStudentId = db.PreviousSchools.Single(x => x.Id == studentId);
            }
            return previousSchoolStudentId;
        }
      

        #endregion

        #region List
        public static List<Student> GetAllStudents()
        {
            var studentList = new List<Student>();
            using (SMSContext db = new SMSContext())
            {
                studentList = db.Students.ToList();
            }
            return studentList;
        }

        public static List<Student> GetAllStudentByFatherCNIC(string fatherCNIC)
        {
            var studentList = new List<Student>();
            using (SMSContext db = new SMSContext())
            {
                studentList = db.Students.Where(x=> x.FatherCNIC==fatherCNIC).ToList();
            }
            return studentList;
        }

        public static List<Student> GetAllStudentByFatherName(string fatherName)
        {
            var studentList = new List<Student>();
            using (SMSContext db = new SMSContext())
            {
                studentList = db.Students.Where(x=> x.FatherName==fatherName).ToList();
            }
            return studentList;
        }

        public static List<PreviousSchool> GetAllPreviousSchools()
        {
            var previousSchool = new List<PreviousSchool>();
            using (SMSContext db = new SMSContext())
            {
                previousSchool = db.PreviousSchools.ToList();
            }
            return previousSchool;
        }

        public static List<PreviousSchool> GetAllStudentsByInstituteName(string instituteName)
        {
            var studentByInstituteList = new List<PreviousSchool>();
            using (SMSContext db = new SMSContext())
            {
                studentByInstituteList = db.PreviousSchools.Where(x => x.InstituteName == instituteName).ToList();
            }
            return studentByInstituteList;
        }

       

        #endregion

    }
}