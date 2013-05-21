using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace CalendarSystem
{
    public class EventsManagerFast : IEventsManager
    {
        private readonly MultiDictionary<string, Event> title;
        private readonly OrderedMultiDictionary<DateTime, Event> dateTime;

        public EventsManagerFast()
        {
            bool allowDuplicateValues = true;
            this.title = new MultiDictionary<string, Event>(allowDuplicateValues);
            this.dateTime = new OrderedMultiDictionary<DateTime, Event>(allowDuplicateValues);
        }

        public void AddEvent(Event ev)
        {
            string eventTitleLowerCase = ev.Title.ToLowerInvariant();
            this.title.Add(eventTitleLowerCase, ev);
            this.dateTime.Add(ev.DateTime, ev);
        }

        public int DeleteEventsByTitle(string title)
        {
            string eventTitleLowerCase = title.ToLowerInvariant();
            var deletedEvents = this.title[eventTitleLowerCase];
            int eventsCount = deletedEvents.Count;

            foreach (var ev in deletedEvents)
            {
                this.dateTime.Remove(ev.DateTime, ev);
            }

            this.title.Remove(eventTitleLowerCase);

            return eventsCount;
        }

        public IEnumerable<Event> ListEvents(DateTime dateTime, int count)
        {
            var events =
                from ev in this.dateTime.RangeFrom(dateTime, true).Values
                select ev;

            var listEvents = events.Take(count);
            return listEvents;
        }

        public int Count
        {
            get
            {
                return this.title.KeyValuePairs.Count;
            }

        }
    }
}
