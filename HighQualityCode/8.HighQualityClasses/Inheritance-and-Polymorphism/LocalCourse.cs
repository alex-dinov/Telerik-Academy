using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string name)
            :this(name, null, null)
        {
        }

        public LocalCourse(string name, string teacherName)
            :this(name, teacherName, null)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            :base(name, teacherName, students)
        {
            this.Lab = string.Empty;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
