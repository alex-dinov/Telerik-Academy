using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(int age,string name):base(age,name,Sex.male)
        {
        }

        public Sex Sex
        {
            get { return Sex.male; }
        }

        public void makeSound()
        {
            Console.WriteLine("Mauw mauw");
        }
    }
}
