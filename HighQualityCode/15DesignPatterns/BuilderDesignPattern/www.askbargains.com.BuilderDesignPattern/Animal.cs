using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public abstract class Animal
        {
            public string Head { get; set; }
            public string Body { get; set; }
            public string Leg { get; set; }
            public string Arm { get; set; }
            public string Tail { get; set; }

         
            public abstract void Eat();

            public void ShowMe()
            {
                Console.WriteLine(Head);
                Console.WriteLine(Body);
                Console.WriteLine(Leg);
                Console.WriteLine(Arm);
                Console.WriteLine(Tail);
                Eat();

            }
        }
    }
}
