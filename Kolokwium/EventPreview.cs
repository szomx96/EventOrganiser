using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kolokwium.Views;

namespace Kolokwium
{
    public partial class EventPreview : Form, IPreview
    {
        private MainApp form1;
        public EventPreview(MainApp ParentForm)
        {
            InitializeComponent();
            form1 = ParentForm;
        }


        public string EventName
        {            
            set
            {
                labelNameValue.Text = value;

            }
        }

        public string EventDate
        {
            set
            {
                labelDateValue.Text = value;
            }
        }

        public string EventTime
        {           
            set
            {
                labelTimeValue.Text = value;
            }

        }
        public string EventPlace
        {           
            set
            {
                labelPlaceValue.Text = value;
            }
        }
        public string EventOrganiser
        {         

            set
            {
                labelOrganiserValue.Text = value;
            }
        }


        private void EventPreview_Load(object sender, EventArgs e)
        {
            if (form1.SelectedIndex >= 0)
            {
                labelNameValue.Text = form1.Org.eventList[form1.SelectedIndex].EventName;
                labelDateValue.Text = form1.Org.eventList[form1.SelectedIndex].EventDate;
                labelTimeValue.Text = form1.Org.eventList[form1.SelectedIndex].EventTime;
                labelPlaceValue.Text = form1.Org.eventList[form1.SelectedIndex].EventPlace;
                labelOrganiserValue.Text = form1.Org.eventList[form1.SelectedIndex].EventOrganiser;
            }
        }

        

    }
}
