using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comment = Comment;
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
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}
