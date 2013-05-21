using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public class KittenBuilder : AnimalBuilder
        {
            public KittenBuilder()
            {
                aAnimal = new Kitten();
            }

            public override void BuildAnimalHeader()
            {
                aAnimal.Head = "Kitten's Head has been built";
            }

            public override void BuildAnimalBody()
            {
                aAnimal.Body = "Kitten's Body has been built";
            }

            public override void BuildAnimalLeg()
            {
                aAnimal.Leg = "Kitten's Leg has been built";
            }

            public override void BuildAnimalArm()
            {
                aAnimal.Arm = "Kitten's Arm has been built";
            }

            public override void BuildAnimalTail()
            {
                aAnimal.Tail = "Kitten's Tail has been built";
            }
        }
    }
}
