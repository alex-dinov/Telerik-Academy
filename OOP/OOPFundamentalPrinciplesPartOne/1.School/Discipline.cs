using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
        }
    }
}
