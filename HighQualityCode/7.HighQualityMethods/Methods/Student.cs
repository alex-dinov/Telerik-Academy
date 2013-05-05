using System;

namespace Methods
{
    public class Student
    {
        public Student(string firstName, string lastName, string otherInfo, string birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
            this.BirthDate = DateTime.Parse(birthDate);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstBirthDate = this.BirthDate;
            DateTime secondBirthDate = otherStudent.BirthDate;
            bool isOlder = firstBirthDate < secondBirthDate;

            return isOlder;
        }
    }
}
