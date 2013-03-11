using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(int age, string name, Sex sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Sex Sex
        {
            get { return this.sex; }
        }
    }
}
