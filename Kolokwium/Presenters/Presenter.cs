using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            view.VRemoveEvent += View_RemoveEvent;
            view.VEditEvent += View_EditEvent;
            view.VCBoxDropDown += View_CBoxDropDownEvent;
            view.VEditClick += View_VEditClick;
           
        }

        private void View_VEditClick(object arg1, EventArgs arg2)
        {
            view.DateElements = model.getDate(view.Org.eventList[view.SelectedIndex].EventDate);
            view.TimeElements = model.getTime(view.Org.eventList[view.SelectedIndex].EventTime);          

        }

        private void View_CBoxDropDownEvent(object arg1, EventArgs arg2)
        {
            view.CBoxElements = model.GetCBoxElements(arg1);
            ComboBox cb = arg1 as ComboBox;
            cb.Items.AddRange(view.CBoxElements);
            
        }

        private void View_RemoveEvent(object arg1, EventArgs arg2)
        {
            view.Org.eventList.RemoveAt(view.SelectedIndex);
        }

        private void View_EditEvent(object arg1, EventArgs arg2)
        {          

            Event toEdit = view.Org.eventList[view.SelectedIndex];

            view.NewEvent = model.EditEvent(toEdit, view.EventName, view.EventDate, view.EventTime,
                view.EventPlace, view.EventOrganiser);
            
            view.Org.eventList.Insert(view.SelectedIndex, view.NewEvent);
            view.Org.eventList.RemoveAt(view.SelectedIndex+1);


        }

        private void View_AddEvent(object arg1, EventArgs arg2)
        {
            if(view.Org == null)
            {
                view.Org = model.CreateNewOrganiser();
            }

            view.NewEvent = model.CreateNewEvent(view.EventName, view.EventDate, view.EventTime,
                view.EventPlace, view.EventOrganiser);

            view.Org.eventList.Add(view.NewEvent);

        }


    }
}
