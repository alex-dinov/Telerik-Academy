using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public class Frog : Animal,ISound
    {
        public Frog(int age,string name,Sex sex):base(age,name,sex)
        {
        }

        public void makeSound()
        {
            Console.WriteLine("Frog frog");
        }
    }
}
