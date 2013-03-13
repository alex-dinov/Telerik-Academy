using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Frog(10,"John",Sex.male),
                new Kitten(5,"Pussy"),
                new Tomcat(6,"Kasanova"),
                new Dog(4,"Balkan",Sex.male),
                new Dog(5,"Pencho",Sex.male),
                new Kitten(2,"Penka"),
                new Kitten(3,"Virginia"),
                new Tomcat(8,"Kotkar"),
                new Tomcat(3,"Garfield")
            };
            GetAverageAge(animals);
        }

        static void GetAverageAge(Animal[] animals)
        {
            var speciesByAverageAge =
                from animal in animals
                group animal by animal.GetType() into a
                select new { Species = a.Key.Name, AverageAge = a.Average(animal => animal.Age) };

            foreach (var species in speciesByAverageAge)
            {
                Console.WriteLine("{0} Average age: {1}",species.Species,species.AverageAge);
            }
        }
    }
}
