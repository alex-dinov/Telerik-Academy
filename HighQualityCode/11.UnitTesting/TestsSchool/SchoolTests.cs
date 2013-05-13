using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Lib;

namespace TestsSchool
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void CreateSchool()
        {
            School.Lib.School school = new School.Lib.School();
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddStudent()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddStudent("lala", 10000);
            Assert.AreEqual("lala", school.GetStudentByUID(10000).Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddBadIDStudentLow()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddStudent("lala", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddBadIDStudentHigh()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddStudent("lala", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddDuplicatedIDStudent()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddStudent("lala", 10000);
            school.AddStudent("2222", 10000);
        }

        [TestMethod]
        public void AddCourse()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddCourse(new Course("lol"));
            Assert.AreEqual("lol", school.GetCourseByName("lol").CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddDuplicatedCourse()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddCourse(new Course("lol"));
            school.AddCourse(new Course("lol"));
        }

        [TestMethod]
        public void AddCourseWithStudents()
        {
            School.Lib.School school = new School.Lib.School();
            school.AddCourse("lol", new Student("lele", 10000), new Student("male", 10001));
            Assert.AreEqual("lol", school.GetCourseByName("lol").CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetInvalidCourseName()
        {
            School.Lib.School school = new School.Lib.School();
            school.GetCourseByName("lal");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetInvalidStudentID()
        {
            School.Lib.School school = new School.Lib.School();
            school.GetStudentByUID(10000);
        }
    }
}
