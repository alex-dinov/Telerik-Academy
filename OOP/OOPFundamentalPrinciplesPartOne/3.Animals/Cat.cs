using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    public abstract class Cat: Animal
    {
        public Cat(int age, string name,Sex sex) :base(age,name,sex)
        {
        }
    }
}
