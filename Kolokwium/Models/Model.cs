using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolokwium.Models
{
    public class Model
    {
        public Model() { }

        internal Event CreateNewEvent(string EventName, string EventDate, string EventTime,
            string EventPlace, string EventOrganiser)
        {
            return new Event(EventName, EventDate, EventTime, EventPlace, EventOrganiser);
        }

        internal Event EditEvent(Event ev, string eventName, string eventDate, string eventTime,
                string eventPlace, string eventOrganiser)
        {
            ev.EventName = eventName;
            ev.EventDate = eventDate;
            ev.EventTime = eventTime;
            ev.EventPlace = eventPlace;
            ev.EventOrganiser = eventOrganiser;

            return ev;            

        }

       

        internal Organiser CreateNewOrganiser()
        {
            return new Organiser();
        }

        



    }
}
