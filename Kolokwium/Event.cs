using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kolokwium
{
    public class Event
    {
        [XmlElement("EventName")]
        public string EventName { get; set; }
        [XmlElement("EventDate")]
        public string EventDate { get; set; }
        [XmlElement("EventTime")]
        public string EventTime { get; set; }
        [XmlElement("EventPlace")]
        public string EventPlace { get; set; }
        [XmlElement("EventOrganiser")]
        public string EventOrganiser { get; set; }

        public Event(string eventName, string eventDate, string eventTime, string eventPlace,
            string eventOrganiser)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            EventPlace = eventPlace;
            EventOrganiser = eventOrganiser;
        }

        public Event()
        {
            EventName = "";
            EventDate = "";
            EventTime = "";
            EventPlace = "";
            EventOrganiser = "";

        }

        //public static implicit operator string(Event v)
        //{
        //    throw new NotImplementedException();
        //}
    }

    [XmlRoot("ArrayOfEvent")]
    public class Organiser
    {
        [XmlElement("Event")]
        public List<Event> eventList;

        public Organiser()
        {
            eventList = new List<Event>();
        }


    }

}
