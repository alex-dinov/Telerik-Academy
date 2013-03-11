using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class School
    {
        private string name;
        private List<Class> classes;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Discipline> disciplines;

        public School(string name)
        {
            this.name = name;
            this.classes = new List<Class>();
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            this.disciplines = new List<Discipline>();
        }

        public string Name
        {
            get { return this.name; }
        }

        public IEnumerable<Class> Classes
        {
            get { return this.classes; }
        }

        public IEnumerable<Student> Students
        {
            get { return this.students; }
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return this.teachers; }
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }

        public void AddClass(Class @class)
        {
            classes.Add(@class);
            foreach (Student student in @class.Students)
            {
                if (!students.Contains(student))
                {
                    students.Add(student);
                }
            }
        }
    }
}
