using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarSystem
{
    public class EventsManager : IEventsManager
    {
        private readonly List<Event> eventsList = new List<Event>();

        /// <summary>
        /// Add event in the event list.
        /// </summary>
        /// <param name="ev">Event that we add in the event list</param>
        public void AddEvent(Event ev)
        {
            this.eventsList.Add(ev);
        }

        /// <summary>
        /// Delete event from the event list by given title.
        /// </summary>
        /// <param name="title">The title of the event</param>
        /// <returns>Returns count of events that were deleted.</returns>
        public int DeleteEventsByTitle(string title)
        {
            var deletedEventsCount = this.eventsList.RemoveAll(
                ev => ev.Title.ToLowerInvariant() == title.ToLowerInvariant());

            return deletedEventsCount;
        }

        /// <summary>
        /// Finds all events that are upcoming in the event list.
        /// </summary>
        /// <param name="dateTime">Given date time that must be bigger or equal to match the event </param>
        /// <param name="count">Count that will be listed.If count is bigger than actual events - list all the events</param>
        /// <returns>List of matching events</returns>
        public IEnumerable<Event> ListEvents(DateTime dateTime, int count)
        {
            var listEvents =
                (from ev in this.eventsList
                 where ev.DateTime >= dateTime
                 orderby ev.DateTime, ev.Title, ev.Location
                 select ev).Take(count);

            return listEvents;
        }
    }
}
