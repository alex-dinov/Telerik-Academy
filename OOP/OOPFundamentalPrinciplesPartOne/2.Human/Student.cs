using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Human
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set 
            {
                if (value <= 0 || value > 12)
                {
                    throw new ArgumentException("Grades are from 1 to 12");
                }
                this.grade = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("{0} grade: {1}", base.ToString(), this.grade);
        }
    }
}
