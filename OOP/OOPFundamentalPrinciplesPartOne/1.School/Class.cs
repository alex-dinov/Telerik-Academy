using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Class : IComment
    {
        private string uniqueTextIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comment;

        public Class(string uniqueTextIdentifier)
        {
            this.uniqueTextIdentifier = uniqueTextIdentifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
            this.comment = Comment;
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
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
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
