using System;
using System.Linq;

namespace CalendarSystem
{
    public class Program
    {
        internal static void Main()
        {
            //Bottleneck
            //In the class EventsManager, the method ListEvents() is slow, because the sorting.
            //The solution is to use the class EventsManagerFast
            IEventsManager eventManager = new EventsManager();
            EventCommand eventCommand = new EventCommand(eventManager);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End" || input == null)
                {
                    break;
                }

                try
                {
                    var parsedCommand = Command.Parse(input);
                    var command = eventCommand.ProcessCommand(parsedCommand);
                    Console.WriteLine(command);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }
    }
}