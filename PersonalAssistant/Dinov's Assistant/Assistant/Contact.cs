using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    class Contact
    {
        public Person Person { get; set; }

        public Contact(Person person)
        {
            this.Person = person;
        }

        public override string ToString()
        {
            return string.Format(this.Person.Name + " " + this.Person.Firm.Name ?? null);
        }
    }
}
