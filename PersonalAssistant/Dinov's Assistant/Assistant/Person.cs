using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    class Person
    {
        public string Name { get; set; }
        public Firm Firm { get; set; }

        public Person(string name) : this (name,new Firm())
        {
        }

        public Person(string name,Firm firm)
        {
            this.Name = name;
            this.Firm = firm;
        }
    }
}
