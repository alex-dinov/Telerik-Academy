using System;
using System.Linq;

namespace Minesweeper
{
    public class Points
    {
        private string name;
        private int totalPoints;

        public Points(string name, int totalPoints)
        {
            this.name = name;
            this.totalPoints = totalPoints;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set 
            { 
                this.name = value; 
            }
        }

        public int TotalPoints
        {
            get 
            { 
                return this.totalPoints; 
            }

            set 
            { 
                this.totalPoints = value; 
            }
        }
    }
}
