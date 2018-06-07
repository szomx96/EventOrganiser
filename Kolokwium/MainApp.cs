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
    public partial class MainApp : Form, IView
    {
        public MainApp()
        {
            InitializeComponent();

        }

        // public Event EventArray { get; set; }

        //public Organiser Og = new Organiser();

        public Organiser Org{get; set;}
        public string[] CBoxElements { get; set; }
        

        public string EventName {

            get
            {
                return textBoxName.Text;
            }
            set
            {
                textBoxName.Text = value;

            }
        }

        public string EventDate
        {
            get
            {
                return comboBoxDateD.SelectedItem.ToString() + "-" + comboBoxDateM.SelectedItem.ToString() +
                     "-" + comboBoxDateY.SelectedItem.ToString();
            }
            set
            {
                comboBoxDateD.Text = value;
                comboBoxDateM.Text = value;
                comboBoxDateY.Text = value;            
            }
        }

        public string EventTime {

            get
            {
                return comboBoxTimeHH.SelectedItem.ToString() + ":" + comboBoxTimeMM.SelectedItem.ToString();
            }
            set
            {
                comboBoxTimeMM.Text = value;
                comboBoxTimeHH.Text = value;
                
            }

        }
        public string EventPlace
        {
            get
            {
                return textBoxPlace.Text;
            }
            set
            {
                textBoxPlace.Text = value;
            }
        }
        public string EventOrganiser
        {
            get
            {
                return textBoxOrganiser.Text;
            }
            set
            {
                textBoxOrganiser.Text = value;
            }
        }
        public Event NewEvent { get; set; }

       

        public int SelectedIndex{
            get
            {
                return listBoxEvents.SelectedIndex;
            }
            set
            {
                listBoxEvents.SelectedIndex = value;
            }
        }

        public string[] DateElements { get; set; }
        public string[] TimeElements { get; set; }
       

        public event Action <object, EventArgs> VAddEvent;

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxName) && /*IsNotEmpty(textBoxDate) && /*IsNotEmpty(textBoxTime) &&*/
                IsNotEmpty(textBoxPlace) && IsNotEmpty(textBoxOrganiser))
            {
                if (VAddEvent != null)
                {
                    VAddEvent(sender, e);                                  

                    AddEvent(NewEvent); //dodawnie do listy
                    buttonSave.Visible = false;
                }
            }
        }

        public event Action<object, EventArgs> VRemoveEvent;

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listBoxEvents.SelectedIndex > -1)
            {
                if(VRemoveEvent != null)
                {
                    VRemoveEvent(sender, e); 
                    RemoveEvent(); // tylko z listy
                }
            }
        }

        public void RemoveEvent()
        {
            listBoxEvents.Items.RemoveAt(SelectedIndex);
        }

        public event Action<object, EventArgs> VEditEvent;
        public event Action<object, EventArgs> VEditClick;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listBoxEvents.SelectedIndex > -1)
            {

                if (VEditClick != null)
                {
                    VEditClick(sender, e);

                    textBoxName.Text = Org.eventList[SelectedIndex].EventName;
                    comboBoxDateD.Text = DateElements[0];
                    comboBoxDateM.Text = DateElements[1];
                    comboBoxDateY.Text = DateElements[2];
                    comboBoxTimeHH.Text = TimeElements[0];
                    comboBoxTimeMM.Text = TimeElements[1];
                    textBoxPlace.Text = Org.eventList[SelectedIndex].EventPlace;
                    textBoxOrganiser.Text = Org.eventList[SelectedIndex].EventOrganiser;

                    buttonSave.Visible = true;
                }
            }

        }
       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            VEditEvent(sender, e);
            EditEvent(NewEvent);
            buttonSave.Visible = false;
        }



        public void AddEvent(Event newEvent){

            if(!listBoxEvents.Items.Contains(newEvent)){                            

                 listBoxEvents.Items.Add(newEvent.EventDate + " " + newEvent.EventTime + 
                     " " + newEvent.EventName);

                ClearTextBoxes();                
            }

        }

        public void EditEvent(Event newEvent)
        {
            listBoxEvents.Items[SelectedIndex] = newEvent.EventDate + " " + newEvent.EventTime +
                    " " + newEvent.EventName;

                ClearTextBoxes();          

        }


        private bool IsNotEmpty(TextBox t)
        {
            if(t.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            comboBoxDateD.Text = "";
            comboBoxDateM.Text = "";
            comboBoxDateY.Text = "";
            comboBoxTimeHH.Text = "";
            comboBoxTimeMM.Text = "";
            textBoxPlace.Clear();
            textBoxOrganiser.Clear();
        }

       

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventPreview eventP = new EventPreview(this);
            DialogResult dr = eventP.ShowDialog(this);
        }   

       

        private void FillListBox()
        {  
            foreach (var e in Org.eventList)
            {
                AddEvent(e);
            }                    
          
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            openFileDialog1.ShowDialog();
            Org = LoadXML.LoadData(openFileDialog1.FileName);
            FillListBox();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            SaveXML.SaveData(Org.eventList, saveFileDialog1.FileName);
        }

        public event Action<object, EventArgs> VCBoxDropDown;

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            if(VCBoxDropDown != null)
            {
                VCBoxDropDown(sender, e);
                
            }            
        }
        
        //string[] ReturnDate()
        //{

        //}

        
    }
}
