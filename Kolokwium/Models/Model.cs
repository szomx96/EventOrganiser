using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        internal string[] getDate(string date)
        {
            string[] dateArray = new string[3];


            date = date.Replace("-", "");
            dateArray[0] = date.Substring(0, 2);
            dateArray[1] = date.Substring(2, 2);
            dateArray[2] = date.Substring(4, 4);

            return dateArray;
        }

        internal string[] getTime(string time)
        {
            string[] timeArray = new string[2];

            time = time.Replace(":", "");

            timeArray[0] = time.Substring(0, 2);
            timeArray[1] = time.Substring(2, 2);

            return timeArray;
        }

        internal string[] GetCBoxElements(object sender)
        {
            int size = 0;
            int j = 0;
            int k = 0;
            ComboBox b = sender as ComboBox;

            if(b.Name == "comboBoxTimeMM")
            {
                size = 60;
                j = 0;
                k = 60;
            }else if(b.Name == "comboBoxTimeHH")
            {
                size = 24;
                j = 0;
                k = 24;
            }else if(b.Name == "comboBoxDateD")
            {
                size = 31;
                j = 1;
                k = 32;
            }else if(b.Name == "comboBoxDateM")
            {
                size = 12;
                j = 1;
                k = 13;
            }else if(b.Name == "comboBoxDateY")
            {
                size = 100;
                j = 2010;
                k = 2110;
            }

            string[] elements = new string[size];

            for (int i = j ; i < k; i++)
            {
                if (i < 10)
                {
                    elements[i-j] = "0" + i.ToString();
                }
                else
                {
                    elements[i-j] = i.ToString();
                }
            }           

            return elements;
        }

       

        internal Organiser CreateNewOrganiser()
        {
            return new Organiser();
        }

        



    }
}
