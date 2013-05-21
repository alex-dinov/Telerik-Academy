using System;
using System.Linq;
using System.Text;

namespace CalendarSystem
{
    public class Event : IComparable<Event>
    {
        public DateTime DateTime { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0:yyyy-MM-ddTHH:mm:ss} | {1}", this.DateTime, this.Title);
            if (this.Location != null)
            {
                output.AppendFormat(" | {0}", this.Location);
            }

            return output.ToString();
        }

        public int CompareTo(Event ev)
        {
            int comparedEvent = DateTime.Compare(this.DateTime, ev.DateTime);

            return comparedEvent;
        }
    }
}
