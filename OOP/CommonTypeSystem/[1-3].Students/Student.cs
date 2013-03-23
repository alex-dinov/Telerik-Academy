using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_.Students
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public int? MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public Student() : this (null,null,
            null,null,null,null,null,null,Specialty.Unknown,University.Unknown,Faculty.Unknown)
        {
        }

        public Student(string firstName, string midddleName, string lastName, string SSN,
            string permanentAddress, int? mobilePhone, string email, string course,
            Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = midddleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName,student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            if (!Object.Equals(this.PermanentAddress, student.PermanentAddress))
            {
                return false;
            }
            if (this.MobilePhone != student.MobilePhone)
            {
                return false;
            }
            if (!Object.Equals(this.Email, student.Email))
            {
                return false;
            }
            if (!Object.Equals(this.Course, student.Course))
            {
                return false;
            }
            if (!Object.Equals(this.Specialty, student.Specialty))
            {
                return false;
            }
            if (!Object.Equals(this.University, student.University))
            {
                return false;
            }
            if (!Object.Equals(this.Faculty, student.Faculty))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Object.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Object.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode() ^
                PermanentAddress.GetHashCode() ^ MobilePhone.GetHashCode() ^ Email.GetHashCode() ^ Course.GetHashCode() ^
                Specialty.GetHashCode() ^ University.GetHashCode() ^ Faculty.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0} {1} {2}\n",this.FirstName,this.MiddleName,this.LastName);
            sb.AppendFormat("SSN: {0}\n",this.SSN);
            sb.AppendFormat("Permanent Address: {0}\n", this.PermanentAddress);
            sb.AppendFormat("Mobile phone: {0}   Email: {1}\n", this.MobilePhone,this.Email);
            sb.AppendFormat("Course: {0}    Specialty: {1}\n", this.Course,this.Specialty);
            sb.AppendFormat("University: {0}       Faculty: {1}\n", this.University,this.Faculty);
            return sb.ToString();
        }

        public Student Clone()
        {
            Student clone = new Student(
                this.FirstName,this.MiddleName,this.LastName,this.SSN,
                this.PermanentAddress,this.MobilePhone,this.Email,this.Course,
                this.Specialty,this.University,this.Faculty);

            return clone;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return 0;
            }
        }
    }
}
