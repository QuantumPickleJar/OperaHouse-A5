using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment5
{
    class TicketComparer : IComparer<Event>
    {
        public int Compare(Event e1, Event e2)
        {
            if (e1.NumAvailableTickets == e2.NumAvailableTickets)
                return 0;
            return e1.NumAvailableTickets > e2.NumAvailableTickets ? 1 : 0;
        }
    }
    class TitleComparer : IComparer<Event>
    {
        public int Compare(Event e1, Event e2)
        {
            return e1.Title.CompareTo(e2.Title);
        }
    }

    class PerformerComparer : IComparer<Event>
    {
        public int Compare(Event e1, Event e2)
        {
            return e1.Performer.Name.CompareTo(e2.Performer.Name);
        }
    }

    class PerformerDateComparer : IComparer<Event>
    {
        public int Compare(Event e1, Event e2)
        {
            if (e1.Performer.Name == e2.Performer.Name)
                return e1.EventTime.CompareTo(e2.EventTime);
            else
            {
                return e1.Performer.Name.CompareTo(e2.Performer.Name);
            }
        }
    }
}

