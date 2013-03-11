using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Teacher : IPerson, IComment
    {
        private string firstName;
        private string lastName;
        private string comment;
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.disciplines = new List<Discipline>();
            this.comment = Comment;
        }

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }
    }
}
