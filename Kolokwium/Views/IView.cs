using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Views
{
    public interface IView
    {
        string EventName { get; set; }
        string EventDate { get; set; }
        string EventTime { get; set; }
        string EventPlace { get; set; }
        string EventOrganiser { get; set; }


        Organiser Org { get; set; }       
        Event NewEvent { get; set; }

        int SelectedIndex { get; set; }  


        event Action <object, EventArgs> VAddEvent;
        event Action<object, EventArgs> VRemoveEvent;
        event Action<object, EventArgs> VEditEvent;
    


    }
}
