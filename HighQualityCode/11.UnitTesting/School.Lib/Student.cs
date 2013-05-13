using System;
using System.Linq;

namespace School.Lib
{
    public class Student
    {
        private int uid;
        private string name;

        public Student(string name, int uid)
        {
            this.name = name;
            this.uid = uid;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }

        }

        public int GetUID
        {
            get
            {
                return this.uid;
            }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("uid", "unique id must be between 10000 and 99999");
                }
                this.uid = value;
            }
        }
    }
}
