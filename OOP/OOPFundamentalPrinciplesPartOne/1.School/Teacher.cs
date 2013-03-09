using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Teacher : IPerson
    {
        private string firstName;
        private string lastName;
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.disciplines = new List<Discipline>();
        }

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }
    }
}
