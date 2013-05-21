using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public class MonkeyBuilder : AnimalBuilder
        {

            public MonkeyBuilder()
            {
                aAnimal = new Monkey();
            }

            public override void BuildAnimalHeader()
            {
                aAnimal.Head = "Moneky's Head has been built";
            }

            public override void BuildAnimalBody()
            {
                aAnimal.Body = "Moneky's Body has been built";
            }

            public override void BuildAnimalLeg()
            {
                aAnimal.Leg = "Moneky's Leg has been built";
            }

            public override void BuildAnimalArm()
            {
                aAnimal.Arm = "Moneky's Arm has been built";
            }

            public override void BuildAnimalTail()
            {
                aAnimal.Tail = "Moneky's Tail has been built";
            }
        }
    }
}
