using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class SchoolTest
    {
        static void Main(string[] args)
        {
            School school = new School("Telerik");
            Class aClass = new Class("A");
            Teacher teacherKiselov = new Teacher("Zdravko", "Kiselov");
            teacherKiselov.Comment = "Na kosam";
            Console.WriteLine(teacherKiselov.Comment);

            aClass.AddTeacher(teacherKiselov);
            aClass.AddStudent(new Student("Gosho","Georgiev",1));
            aClass.AddStudent(new Student("Pencho", "Penchev", 2));
            aClass.AddStudent(new Student("Ivan", "Ivanov", 3));
            school.AddClass(aClass);

            foreach (var student in aClass.Students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
