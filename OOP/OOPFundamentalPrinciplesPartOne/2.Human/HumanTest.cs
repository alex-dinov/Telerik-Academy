using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Human
{
    public class HumanTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan","Ivanov" , 2));
            students.Add(new Student("Pencho", "Dimitrov", 4));
            students.Add(new Student("Makarenko", "Makarenov", 7));
            students.Add(new Student("Iliq", "Iliev", 7));
            students.Add(new Student("Gaco", "Bacov", 10));
            students.Add(new Student("John", "Atanasov", 2));
            students.Add(new Student("Bil", "Gates", 11));
            students.Add(new Student("Svetlin", "Nakov", 4));
            students.Add(new Student("Mariq", "Ignatova", 2));
            students.Add(new Student("Petko", "Ivanov", 2));

            var sortedStudentsByGrade = students.OrderBy(x => x.Grade);
            foreach (var student in sortedStudentsByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------------------");

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("David", "De Gea",20000,8));
            workers.Add(new Worker("Wayne", "Rooney", 120000,8));
            workers.Add(new Worker("Cristiano", "Ronaldo", 150000,8));
            workers.Add(new Worker("Michael", "Carrick", 20000,8));
            workers.Add(new Worker("Shinji", "Kagawa", 10000,8));
            workers.Add(new Worker("Ryan", "Gigs",10000,4));
            workers.Add(new Worker("Ashley", "Young", 11000,8));
            workers.Add(new Worker("Nemanja", "Vidic", 100000,8));
            workers.Add(new Worker("Rio", "Ferdinad", 120000,8));
            workers.Add(new Worker("Rafel", "Da Silva", 5,8));

            var sortedWorkersByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkersByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("-----------------------------");

            List<Human> humanStudents = new List<Human>(students);
            List<Human> humanWorkers = new List<Human>(workers);

            var humans = humanStudents.Concat(humanWorkers).ToList();
            var sortedHumansByName = humans.OrderBy(h => h.FirstName).ThenBy(l => l.LastName);
            foreach (var human in sortedHumansByName)
            {
                Console.WriteLine(human);
            }     
        }
    }
}
