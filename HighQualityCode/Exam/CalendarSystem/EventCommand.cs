using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalendarSystem
{
    public class EventCommand
    {
        private readonly IEventsManager eventsProcessor;

        public EventCommand(IEventsManager eventsProcessor)
        {
            this.eventsProcessor = eventsProcessor;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventsProcessor;
            }
        }

        public string ProcessCommand(Command command)
        {
            if ((command.CommandName == "AddEvent") && (command.Parameters.Length == 2))
            {
                return ProcessCommandAddWithTwoParams(command);
            }

            if ((command.CommandName == "AddEvent") && (command.Parameters.Length == 3))
            {
                return ProcessCommandAddWithThreeParams(command);
            }

            if ((command.CommandName == "DeleteEvents") && (command.Parameters.Length == 1))
            {
                return ProcessCommandDeleteEvents(command);
            }
            
            if ((command.CommandName == "ListEvents") && (command.Parameters.Length == 2))
            {
                return ProcessCommandListEvents(command);
            }
            else
            {
                throw new ArgumentException("Invalid command!No such command {0}", command.CommandName);
            }
        }

        private string ProcessCommandListEvents(Command command)
        {
            DateTime date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            int count = int.Parse(command.Parameters[1]);
            var events = this.eventsProcessor.ListEvents(date, count).ToList();
            StringBuilder output = new StringBuilder();

            if (!events.Any())
            {
                return "No events found";
            }

            foreach (var ev in events)
            {
                output.AppendLine(ev.ToString());
            }

            return output.ToString().Trim();
        }

        private string ProcessCommandDeleteEvents(Command command)
        {
            int deletedEventsCount = this.eventsProcessor.DeleteEventsByTitle(command.Parameters[0]);

            string message;
            if (deletedEventsCount == 0)
            {
                message = "No events found.";
                return message;
            }

            message = deletedEventsCount + " events deleted";
            return message;
        }

        private string ProcessCommandAddWithThreeParams(Command command)
        {
            DateTime date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event ev = new Event
            {
                DateTime = date,
                Title = command.Parameters[1],
                Location = command.Parameters[2],
            };

            this.eventsProcessor.AddEvent(ev);

            string message = "Event added";

            return message;
        }

        private string ProcessCommandAddWithTwoParams(Command command)
        {
            DateTime date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            Event ev = new Event
            {
                DateTime = date,
                Title = command.Parameters[1],
                Location = null,
            };

            this.eventsProcessor.AddEvent(ev);
            string message = "Event added";

            return message;
        }
    }
}
