using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment5
{
    public class EventList
    {
        private List<Event> events;

        public EventList()
        {
            events = new List<Event>();
        }
        public void AddEvent(Event e)
        {
            //throw new NotImplementedException();
            events.Add(e);
        }

        public void AddEvent(List<Event> events)
        {
            //throw new NotImplementedException();

            //this.events.AddRange(events);
            // OR:
            foreach (Event e in events)
                this.events.Add(e);
        }

        //Reverse sorting regardless of what it is currently
        public void ReverseSort()
        {
            events.Reverse();
        }
        public void SortByDate()
        {
            //throw new NotImplementedException();
            events.Sort(); //Natural Sort order is Date
        }
        public void SortReverseByDate()
        {
            events.Sort();
            events.Reverse();
        }

        public void SortByTitle()
        {
            //throw new NotImplementedException();
            events.Sort(new TitleComparer());
        }

        //Overloaded example of sorting - 
        //the parameter controls whether it's ascending or descending
        public void SortByTitle(bool reverse)
        {
            events.Sort(new TitleComparer());
            if (reverse)
                events.Reverse();
        }

        public List<Event> SearchByPerformer(string name)
        {
            //throw new NotImplementedException();
            List<Event> result = new List<Event>();
            foreach (Event e in events)
            {
                if (e.Performer.Name.Contains(name))   // == name)
                    result.Add(e);
            }
            return result;
        }

        public List<Event> SearchByStage(Stage stage)
        {
            //throw new NotImplementedException();
            List<Event> result = new List<Event>();
            foreach (Event e in events)
            {
                if (e.Stage==stage)   // == name)
                    result.Add(e);
            }
            return result;
        }

        public List<Event> OpenShows()
        {
            //throw new NotImplementedException();
            List<Event> result = new List<Event>();
            foreach (Event e in events)
            {
                if (!e.IsSoldOut)
                    result.Add(e);
            }
            return result;
        }

        public void Sort()
        {
            //throw new NotImplementedException();
            events.Sort();
        }

        public List<Event> ShowsShorterThan(int minutes)
        {
            //throw new NotImplementedException();
            List<Event> result = new List<Event>();
            foreach (Event e in events)
            {
                if (e.DurationMinutes < minutes)
                    result.Add(e);
            }
            return result;
        }

        //Helper method that returns the IDs of all the events in the order listed in the List 
        //This is for testing purposes only
        public string[] eventIDs()
        {
            string[] ids = new string[events.Count];
            int i = 0;
            foreach (Event e in events)
            {
                ids[i] = e.ID;
                i++;
            }
            return ids;
        }

        public void SortByPerformer()
        {
            //throw new NotImplementedException();
            events.Sort(new PerformerComparer());
        }

        public void SortByPerformerDate()
        {
            events.Sort(new PerformerDateComparer());
        }

        public bool Contains(Event e)
        {
            return events.Contains(e);
        }
    }
}
