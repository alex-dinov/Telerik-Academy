using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Human
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName,string lastName,int weekSalary, int workHoursPerDay) 
            : base(firstName,lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be negative!");
                }
                this.weekSalary = value; 
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day cannot be negative!");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return ((double)weekSalary / (5 * workHoursPerDay));
        }

        public override string ToString()
        {
            return string.Format("{0} week salary: {1:C} work hours per day: {2}", base.ToString(), this.weekSalary, this.workHoursPerDay);
        }
    }
}
