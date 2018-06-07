using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium.Models;
using Kolokwium.Views;


namespace Kolokwium.Presenters
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(Model model, IView view)
        {
            this.view = view;
            this.model = model;

            view.VAddEvent += View_AddEvent;
           
        }

        private void View_AddEvent(object arg1, EventArgs arg2)
        {
            if(view.Org == null)
            {
                view.Org = model.CreateNewOrganiser();
            }

            view.NewEvent = model.CreateNewEvent(view.EventName, view.EventDate, view.EventTime,
                view.EventPlace, view.EventOrganiser);

            view.Org.eventList.Add(model.GetEvent(view.NewEvent));

        }

        

                
        //Views.eventList = Model.eventlist.add(New event)

        

      

        



    }
}
