using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperaHouse_Assignment5;
using System.Collections.Generic;
// TODO: move to OperaTesting
namespace OperaHouse_Assignment5
{
    [TestClass]
    public class AcceptCriteriaTest
    {
        Event shrek, deathShow, belushiShow;
        Stage main, lounge;
        Performer drDeath;
        Performer belushi;
        Performer osawaHigh;
        EventList events;

        [TestInitialize]
        public void SetUp()
        {
            osawaHigh = new Performer("Osawa High School", 0);
            drDeath = new Performer("Dr Death", 1500);
            belushi = new Performer("Jim Belushi", 3500);

            shrek = new Event("1", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 18, 19, 30, 0), 60, true);
            deathShow = new Event("2", "Dr. Death's Musical Adventures", drDeath, 200, 20, new DateTime(2015, 4, 25, 19, 0, 0), 90, true);
            belushiShow = new Event("3", "Belushi and the Board of Comedy", belushi, 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false);

            main = new Stage("Main Stage", 100, 150);
            lounge = new Stage("The Lounge", 75, 50);

            events = new EventList();
            events.AddEvent(new List<Event> { shrek, deathShow, belushiShow });
        }

        // As a user, I want to be able to see all scheduled events on a single form so I can
        // see all events at a glance.
        private void TestAllEventsPresentOnForm()
        {
            // assert that the form contains each event
            Assert.IsTrue(events.Contains(shrek));
            Assert.IsTrue(events.Contains(deathShow));
            Assert.IsTrue(events.Contains(belushiShow));
        }

        // As a user, I want to be able to select an event to see more details and make
        //  changes so that the events can be updated to reflect any changes.
        public void EventDetails()
        {

        }

        // As a ticket agent, I want to be able to hide sold-out performances, so I don’t try to
        // sell tickets for them.
        private void ListboxHidesSoldOutShows()
        {

        }

        // As a ticket agent, I want to be able to see performances for a specific performer to
        // make it easier to find what I’m looking for.
        // [ Satisfied by TestSearchByPerformer ] 

        // As a ticket agent, I want to be able to see all the tickets for an event with their
        //  status (sold/unsold) so that I can sell and return individual tickets.
        // TODO: ticket-viewer

        // As a manager, I want to be able to add and remove events from the system, so the
        //  list of events reflects all events we are scheduled to show.

        private void TestRemovedEventHandledSafely()
        {
            // make sure that the removal of the event does not cause any exceptions

            // assert that the count of events is one less than it was before
        }
    }
}