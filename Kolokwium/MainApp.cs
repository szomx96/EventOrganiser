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
                return textBoxDate.Text;
            }
            set
            {
                textBoxDate.Text = value;
            }
        }

        public string EventTime {

            get
            {
                return textBoxTime.Text;
            }
            set
            {
                textBoxTime.Text = value;
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
       

        public event Action <object, EventArgs> VAddEvent;

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxName) && IsNotEmpty(textBoxDate) && IsNotEmpty(textBoxTime) &&
                IsNotEmpty(textBoxPlace) && IsNotEmpty(textBoxOrganiser))
            {
                if (VAddEvent != null)
                {
                    VAddEvent(sender, e);
                    //Og.AddItem(NewEvent);                    

                    AddEvent(NewEvent);
                }
            }
        }

        public void AddEvent(Event newEvent){

            if(!listBoxEvents.Items.Contains(newEvent)){                            

                 listBoxEvents.Items.Add(newEvent.EventDate + " " + newEvent.EventTime + 
                     " " + newEvent.EventName);

                ClearTextBoxes();                
            }

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
            textBoxDate.Clear();
            textBoxTime.Clear();
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
            openFileDialog1.ShowDialog();
            Org = LoadXML.LoadData(openFileDialog1.FileName);
            FillListBox();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            SaveXML.SaveData(Org.eventList, saveFileDialog1.FileName);
        }
    }
}
