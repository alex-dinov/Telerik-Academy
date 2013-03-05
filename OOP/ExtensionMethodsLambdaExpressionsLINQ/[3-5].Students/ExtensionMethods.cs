using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_.Students
{
    public static class ExtensionMethods
    {
        public static void GetStudents(this Array arr,Student[] students)
        {
            var newStudents =
               from student in students
               where student.FirstName.CompareTo(student.LastName) < 0
               select student;
            printStudents(newStudents.ToArray());
        }

        public static void printStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
            }
        }
    }
}
