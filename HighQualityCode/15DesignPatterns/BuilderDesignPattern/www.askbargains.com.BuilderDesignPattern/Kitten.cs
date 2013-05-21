using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public class Kitten : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Since I am Kitten, I like to eat kitten food");
            }
        }
    }
}
