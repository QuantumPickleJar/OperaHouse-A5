﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperaHouse_Assignment5;

namespace OperaHouse_Assignment5
{
    internal class EventsDB
    {
        private static Performer[] performers = new Performer[] { 
            new Performer("Jimony Cricket", 3500),      // peformers[0]
            new Performer("Alex Waldo", 1900),          // performers[1]
            new Performer("Edna Polaski", 4000),         // performers[2]
            new Performer("Osawa High", 0)         // performers[3]
        };

        private Stage mainStg = new Stage("Main Stage", 100, 150);
        private Stage loungeStg = new Stage("The Lounge", 75, 50);
        

        public static List<Event> PopulateEvents()
        {
            //Performer[2] performers = { };

            List<Event> events = new List<Event>();

            Event shrek = new Event("1", "Shrek", performers[3], 150, 12, new DateTime(2015, 4, 18, 19, 30, 0), 60, true);
            Event ednaShow = new Event("2", "Edna's Excellent Embarkment", performers[2], 200, 20, new DateTime(2015, 4, 25, 19, 0, 0), 90, true);
            Event jimShow = new Event("3", "Jimony's Comedy Pavillion", performers[0], 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false);
            Event osawaShow = new Event("4", "Of Mice and Men", performers[1], 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false);
            
            events = new EventList();

            events.AddEvent(new List<Event> { shrek, deathShow, belushiShow });

            return events;
        }

    }
}