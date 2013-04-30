namespace Events
{
    using System;
    using System.Text;

    public static class Messages
    {
        private static readonly StringBuilder output = new StringBuilder();

        public static string OutputMessage 
        {
            get
            {
                return output.ToString();
            }
        }
    
        public static void EventAdded()
        { 
            output.Append("Event added" + Environment.NewLine); 
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted{1}", count, Environment.NewLine);
            }
        }

        public static void NoEventsFound() 
        { 
            output.Append("No events found" + Environment.NewLine); 
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
