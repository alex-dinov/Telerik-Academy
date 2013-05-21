using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public class Monkey : Animal
        {

            public override void Eat()
            {
                Console.WriteLine("Since I am Monkey, I like to eat banana");
            }
        }
    }
}
