using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class UnitTestEventsManagerFast
    {
        [TestMethod]
        public void TestMethodAddSingleEvent()
        {
            Event ev = new Event();
            ev.Title = "party Viki";
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            eventManagerFast.AddEvent(ev);

            Assert.AreEqual(1, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAddDuplicatedEvents()
        {
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "party Viki";
            secondEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            secondEvent.Location = "home";
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);

            Assert.AreEqual(2, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAddMultipleEvents()
        {
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "C# exam";
            secondEvent.DateTime = DateTime.Parse("2012-05-20T10:00:00");
            secondEvent.Location = "Telerik";
            Event thirdEvent = new Event();
            thirdEvent.Title = "party";
            thirdEvent.DateTime = DateTime.Parse("2012-08-20T22:00:00");
            thirdEvent.Location = "Biad";
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);
            eventManagerFast.AddEvent(thirdEvent);

            Assert.AreEqual(3, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAdd500DuplicatedEvents()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            for (int i = 0; i < 500; i++)
            {
                Event ev = new Event();
                ev.Title = "party Viki";
                ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
                ev.Location = "home";
                eventManagerFast.AddEvent(ev);
            }

            Assert.AreEqual(500, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAdd500DifferentEvents()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            for (int i = 0; i < 500; i++)
            {
                Event ev = new Event();
                ev.Title = "party number:" + i + "Viki";
                ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
                ev.Location = "home";
                eventManagerFast.AddEvent(ev);
            }

            Assert.AreEqual(500, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAddEventsWithoutLocation()
        {
            Event ev = new Event();
            ev.Title = "party Viki";
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            eventManagerFast.AddEvent(ev);

            Assert.AreEqual(null, ev.Location);
        }

        [TestMethod]
        public void TestMethodAddEventsOnlyWithTitle()
        {
            Event ev = new Event();
            ev.Title = "party Viki";
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            eventManagerFast.AddEvent(ev);

            Assert.AreEqual("party Viki", ev.Title);
        }

        [TestMethod]
        public void TestMethodAddEventsWithoutTitle()
        {
            Event ev = new Event();
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            if (ev.Title != null)
            {
                eventManagerFast.AddEvent(ev);
            }

            Assert.AreEqual(0, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodAddEventsWithoutDateTime()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event ev = new Event();
            ev.Title = "party number Viki";
            ev.Location = "home";
            eventManagerFast.AddEvent(ev);
            Assert.AreEqual(1, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodListSingleEventWithAccurateCount()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event ev = new Event();
            ev.Title = "party Viki";
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            eventManagerFast.AddEvent(ev);
            var eventsListedCount = eventManagerFast.ListEvents(ev.DateTime, 1);

            Assert.AreEqual(1, eventsListedCount.Count());
        }

        [TestMethod]
        public void TestMethodListSingleEventWithNotAccurateCount()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event ev = new Event();
            ev.Title = "party Viki";
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            eventManagerFast.AddEvent(ev);
            var eventsListedCount = eventManagerFast.ListEvents(ev.DateTime, 5);

            Assert.AreEqual(1, eventsListedCount.Count());
        }

        [TestMethod]
        public void TestMethodListEventsWithDuplicatedDate()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "C# exam";
            secondEvent.DateTime = DateTime.Parse("2012-05-20T10:00:00");
            secondEvent.Location = "Telerik";
            Event thirdEvent = new Event();
            thirdEvent.Title = "party";
            thirdEvent.DateTime = DateTime.Parse("2012-05-20T10:00:00");
            thirdEvent.Location = "Biad";
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);
            eventManagerFast.AddEvent(thirdEvent);
            var eventsListedCount = eventManagerFast.ListEvents(DateTime.Parse("2012-05-20T10:00:00"), 5);

            Assert.AreEqual(2, eventsListedCount.Count());
        }

        [TestMethod]
        public void TestMethodListMultipleEvents()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "C# exam";
            secondEvent.DateTime = DateTime.Parse("2012-05-25T10:00:00");
            secondEvent.Location = "Telerik";
            Event thirdEvent = new Event();
            thirdEvent.Title = "party";
            thirdEvent.DateTime = DateTime.Parse("2012-08-23T22:00:00");
            thirdEvent.Location = "Biad";
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);
            eventManagerFast.AddEvent(thirdEvent);
            var eventsListedCount = eventManagerFast.ListEvents(DateTime.Parse("2011-07-24T10:00:00"), 5);

            Assert.AreEqual(3, eventsListedCount.Count());
        }

        public void TestMethodListEventsWithNoMatchingEvents()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "C# exam";
            secondEvent.DateTime = DateTime.Parse("2012-05-25T10:00:00");
            secondEvent.Location = "Telerik";
            Event thirdEvent = new Event();
            thirdEvent.Title = "party";
            thirdEvent.DateTime = DateTime.Parse("2012-08-23T22:00:00");
            thirdEvent.Location = "Biad";
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);
            eventManagerFast.AddEvent(thirdEvent);
            var eventsListedCount = eventManagerFast.ListEvents(DateTime.Parse("2012-07-24T10:00:00"), 5);

            Assert.AreEqual(0, eventsListedCount.Count());
        }

        [TestMethod]
        public void TestMethodDeleteSingleEventByTitle()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event ev = new Event();
            ev.Title = "party Viki";
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            eventManagerFast.AddEvent(ev);
            eventManagerFast.DeleteEventsByTitle(ev.Title);

            Assert.AreEqual(0, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodDeleteDuplicatedEventsByTitle()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event firstEvent = new Event();
            firstEvent.Title = "party Viki";
            firstEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            firstEvent.Location = "home";
            Event secondEvent = new Event();
            secondEvent.Title = "party Viki";
            secondEvent.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            secondEvent.Location = "home";
            eventManagerFast.AddEvent(firstEvent);
            eventManagerFast.AddEvent(secondEvent);
            eventManagerFast.DeleteEventsByTitle(firstEvent.Title);

            Assert.AreEqual(0, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodDelete500EventsByTitle()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            for (int i = 0; i < 500; i++)
            {
                Event ev = new Event();
                ev.Title = "party Viki";
                ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
                ev.Location = "home";
                eventManagerFast.AddEvent(ev);
                eventManagerFast.DeleteEventsByTitle(ev.Title);
            }

            Assert.AreEqual(0, eventManagerFast.Count);
        }

        [TestMethod]
        public void TestMethodDeleteByTitleEventWithNoTitle()
        {
            EventsManagerFast eventManagerFast = new EventsManagerFast();
            Event ev = new Event();
            ev.DateTime = DateTime.Parse("2012-01-21T20:00:00");
            ev.Location = "home";
            if (ev.Title != null)
            {
                eventManagerFast.AddEvent(ev);
                eventManagerFast.DeleteEventsByTitle(ev.Title);
            }

            Assert.AreEqual(0, eventManagerFast.Count);
        }
    }
}
