using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using www.askbargains.com.BuilderDesignPattern;

namespace www.askbargains.com
{
    namespace Client
    {
        class Program
        {
            static void Main(string[] args)
            {
                //create a constructor object to start building
                Kid aKid = new Kid();
                aKid.Name = "Elizabeth";                

                //Elizabeth use Monkey moid to make a monkey
                Console.WriteLine("{0} start making a monkey",aKid.Name);
                AnimalBuilder builderA = new MonkeyBuilder();
                aKid.MakeAnimal(builderA);
                builderA.aAnimal.ShowMe();

                //Elizabeth use Kitten moid to make a kitten
                 Console.WriteLine("{0} start making a kitten",aKid.Name);
                 AnimalBuilder builderB = new KittenBuilder();
                 aKid.MakeAnimal(builderB);
                 builderB.aAnimal.ShowMe();

                Console.Read();
            }
        }
    }
}
