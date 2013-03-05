using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int? duration;

        public Call() : this(new DateTime(),null,null)
        {
        }

        public Call(DateTime dateAndTime, string dialedPhoneNumber,int? duration)
        {
            if (duration < 0)
            {
                throw new ArgumentException("Call duration cannot be negative");
            }
            this.dateAndTime = dateAndTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        public DateTime DateTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int? Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format
            ("Date and Time: {0}  Dialed Phone Number: {1} \nDuration: {2} seconds\n", 
            this.dateAndTime, this.dialedPhoneNumber, this.duration);
        }
    }
}
