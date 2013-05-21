using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.askbargains.com
{
    namespace BuilderDesignPattern
    {
        public class Kid
        {
            public string Name { get; set; }

            //assembly process to build an animal object
            public void MakeAnimal(AnimalBuilder aAnimalBuilder)
            {
                aAnimalBuilder.BuildAnimalHeader();
                aAnimalBuilder.BuildAnimalBody();
                aAnimalBuilder.BuildAnimalLeg();
                aAnimalBuilder.BuildAnimalArm();
                aAnimalBuilder.BuildAnimalTail();
            }


        }
    }
}
