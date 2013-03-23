using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Person
{
    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age.HasValue ? this.Age.ToString() : "undefined");
        }
    }
}
