using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Class
    {
        private string uniqueTextIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string uniqueTextIdentifier)
        {
            this.uniqueTextIdentifier = uniqueTextIdentifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return this.teachers; }
        }

        public IEnumerable<Student> Students
        {
            get { return this.students; }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
    }
}
