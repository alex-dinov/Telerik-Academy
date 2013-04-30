using System;
using System.Linq;

namespace PersonFactory
{
    class PersonFactoryTest
    {
        static void Main(string[] args)
        {
            PersonFactoryTest factory = new PersonFactoryTest();
            factory.MakePerson(22);
        }

        public void MakePerson(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Pencho";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Penka";
                person.Gender = Gender.Female;
            }
        }
    }
}
