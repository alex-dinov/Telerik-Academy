using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zad.3\n");
            Student[] students = {
                new Student("Zdravko", "Kiselov",20),
                new Student("Ivo", "Andonov",18),
                new Student("Ivo", "Ivanov",18),
                new Student("Aleksandar", "Dimitrov",25),
                new Student("Rosen","Gacov",25)};
            students.GetStudents(students);
            Console.WriteLine("-------------------------------");


            Console.WriteLine("zad.4\n");
            var normalAgeStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            ExtensionMethods.printStudents(normalAgeStudents.ToArray());
            Console.WriteLine("-------------------------------");


            Console.WriteLine("zad.5\n");
            var descendingOrderStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            ExtensionMethods.printStudents(descendingOrderStudents.ToArray());
            Console.WriteLine("-------------------------------");
            //LINQ
            var descendingOrderStudentsByLINQ =
                from student in students
                orderby student.FirstName descending,
                student.LastName descending
                select student;
            ExtensionMethods.printStudents(descendingOrderStudentsByLINQ.ToArray());
        }
    }
}
