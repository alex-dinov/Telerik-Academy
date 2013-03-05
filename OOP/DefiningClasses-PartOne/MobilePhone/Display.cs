using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private decimal? size;
        private int? numOfColors;

        public Display() : this(null,null)
        {
        }

        public Display(decimal? size, int? numOfColors)
        {
            if (size < 0 || numOfColors < 0)
            {
                throw new ArgumentException("Display size or number of colors cannot be negative");
            }
            this.size = size;
            this.numOfColors = numOfColors;
        }

        public decimal? Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Size!Size must be positive number");
                }
                this.size = value;
            }
        }

        public int? NumOfColors
        {
            get { return this.numOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid NumberOfColors!NumberOfColors must be positive number");
                }
                this.numOfColors = value;
            }
        }
    }
}
