using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            ITeacher teacher = new Teacher(name);
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse localCourse = new LocalCourse(name, teacher, lab);
            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse(name, teacher, town);
            return offsiteCourse;
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public abstract class Course : ICourse
    {
        public string Topic { get; set; }

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public Course(string name,ITeacher teacher,string topic)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Topic = topic;
        }


        public void AddTopic(string topic)
        {
            if (Topic != null)
            {
                this.Topic += ", ";
            }
            this.Topic += topic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().Name+": ");
            sb.AppendFormat("Name={0}; ", this.Name);
            if (this.Teacher != null)
            {
                sb.AppendFormat("Teacher={0}; ", Teacher.Name ?? null);
            }
            if (this.Topic != null)
            {
                sb.AppendFormat("Topics=[{0}; ", this.Topic);
                sb = sb.Remove(sb.Length - 2, 2);
                sb.Append("]; ");
            }
            return sb.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher, null)
        {
            this.Town = town;
        }
        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Town={0}", this.Town);
            return sb.ToString();
        }
    }

    public class Teacher : ITeacher
    {
        public IList<ICourse> Courses { get; set; }

        public string Name { get; set; }

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public Teacher()
            : this(null)
        {
        }

        public void AddCourse(ICourse course)
        {
            Courses.Add(course);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Teacher: ");
            sb.AppendFormat("Name={0}",this.Name);
            if (Courses.Count !=0)
            {
                sb.Append(";");
                sb.Append(" Courses=[");
                int counter = 0;
                foreach (var course in Courses)
                {
                    if (Courses.Count-1 == counter)
                    {
                        sb.Append(course.Name);
                        break;
                    }
                    sb.AppendFormat(course.Name + ", ");
                    counter++;
                }
                sb.Append("]");
            }
            return sb.ToString();
        }

    }

    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }

        public LocalCourse(string name, ITeacher teacher, string lab):base(name,teacher,null)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Lab={0}", this.Lab);
            return sb.ToString();
        }
    }
}
