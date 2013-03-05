using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_.Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int? age;

        public Student(string firstName, string lastName)
            : this(firstName, lastName, null)
        {
        }

        public Student(string firstName, string lastName,int? age)
        {
            if (age < 0 || age > 120)
            {
                throw new ArgumentException("Invalid age!");
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName { get { return this.firstName; } }

        public string LastName { get { return this.lastName; } }

        public int? Age 
        {

            get { return this.age; }
            set 
            {
                if (age < 0 || age > 120)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value; 
            }
        }
    }
}
