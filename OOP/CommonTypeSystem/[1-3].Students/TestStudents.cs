using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_.Students
{
    public class TestStudents
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            firstStudent.FirstName = "Gosho";
            firstStudent.MiddleName = "Ivanov";
            firstStudent.LastName = "Petrov";
            firstStudent.University = University.Economic;
            firstStudent.Specialty = Specialty.Marketing;
            firstStudent.Faculty = Faculty.Economic;

            Student secondStudent = new Student();
            secondStudent.FirstName = "Pencho";
            secondStudent.MiddleName = "Ivanov";
            secondStudent.LastName = "Petrov";
            secondStudent.University = University.Economic;
            secondStudent.Specialty = Specialty.Marketing;
            secondStudent.Faculty = Faculty.Economic;

            if (firstStudent != secondStudent)
            {
                Console.WriteLine("{0}\nIS DIFFERENT THAN \n\n{1}", firstStudent, secondStudent);
            }
            Console.WriteLine("----------------------------------------------");
            secondStudent.FirstName = "Gosho";

            if (firstStudent == secondStudent)
            {
                Console.WriteLine("{0}\nIS SAME AS \n\n{1}", firstStudent, secondStudent);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Cloned student:");

            Student cloneStudent = firstStudent.Clone();
            Console.WriteLine(cloneStudent);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Compare two students: ");
            Console.WriteLine(firstStudent.CompareTo(secondStudent));
        }
    }
}
