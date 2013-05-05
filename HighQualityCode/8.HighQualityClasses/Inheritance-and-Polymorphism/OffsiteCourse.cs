using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name)
            :this(name, null, null)
        {
        }

        public OffsiteCourse(string name, string teacherName)
            :base(name, teacherName, null)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            :base(name, teacherName, students)
        {
            this.Town = string.Empty;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
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
