using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Views
{
    interface IPreview
    {
        string EventName { set; }
        string EventDate { set; }
        string EventTime { set; }
        string EventPlace { set; }
        string EventOrganiser { set; }
        
    }
}
