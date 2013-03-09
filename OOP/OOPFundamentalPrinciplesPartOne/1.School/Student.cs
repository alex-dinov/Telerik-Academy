using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Student : IPerson
    {
        private string firstName;
        private string lastName;
        private int uniqueClassNumber;

        public Student(string firstName, string lastName, int uniqueClassNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.uniqueClassNumber = uniqueClassNumber;
        }

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
        }
    }
}
