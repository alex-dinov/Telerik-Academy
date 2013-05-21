using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public abstract class AnimalBuilder
        {
            public Animal aAnimal;

            public abstract void BuildAnimalHeader();
            public abstract void BuildAnimalBody();
            public abstract void BuildAnimalLeg();
            public abstract void BuildAnimalArm();
            public abstract void BuildAnimalTail();


        }
    }
}
