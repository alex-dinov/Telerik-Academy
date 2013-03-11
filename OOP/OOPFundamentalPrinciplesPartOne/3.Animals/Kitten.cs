using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public class Kitten : Cat
    {
        public Kitten(int age,string name):base(age,name,Sex.female)
        {
        }

        public Sex Sex
        {
            get { return Sex.female; }
        }

        public void makeSound()
        {
            Console.WriteLine("Miew miew");
        }
    }
}
