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

        public Organiser Org{get; set;}
        public string[] CBoxElements { get; set; }
        public Event NewEvent { get; set; }
        public string[] DateElements { get; set; }
        public string[] TimeElements { get; set; }


        public event Action<object, EventArgs> VAddEvent;
        public event Action<object, EventArgs> VRemoveEvent;
        public event Action<object, EventArgs> VEditEvent;
        public event Action<object, EventArgs> VEditClick;
        public event Action<object, EventArgs> VCBoxDropDown;

        #region getters/setters
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
                comboBoxDateD.SelectedItem = value;
                comboBoxDateM.SelectedItem = value;
                comboBoxDateY.SelectedItem = value;            
            }
        }

        public string EventTime {

            get
            {
                return comboBoxTimeHH.SelectedItem.ToString() + ":" + comboBoxTimeMM.SelectedItem.ToString();
            }
            set
            {
                comboBoxTimeMM.SelectedItem = value;
                comboBoxTimeHH.SelectedItem = value;
                
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

        #endregion

        #region actions

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(textBoxName) && AreComboboxesNotEmpty() 
                && IsNotEmpty(textBoxPlace) && IsNotEmpty(textBoxOrganiser))
            {
                if (VAddEvent != null)
                {
                    VAddEvent(sender, e);                                  

                    AddEvent(NewEvent); //dodawnie do listy
                    buttonSave.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


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


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listBoxEvents.SelectedIndex > -1)
            {

                if (VEditClick != null)
                {
                    VEditClick(sender, e);
                    VCBoxDropDown(comboBoxDateD, e);
                    VCBoxDropDown(comboBoxDateM, e);
                    VCBoxDropDown(comboBoxDateY, e);
                    VCBoxDropDown(comboBoxTimeHH, e);
                    VCBoxDropDown(comboBoxTimeMM, e);

                    textBoxName.Text = Org.eventList[SelectedIndex].EventName;                   
                    comboBoxDateD.SelectedIndex = comboBoxDateD.FindStringExact(DateElements[0]);                    
                    comboBoxDateM.SelectedIndex = comboBoxDateM.FindStringExact(DateElements[1]);
                    comboBoxDateY.SelectedIndex = comboBoxDateY.FindStringExact(DateElements[2]);                   
                    comboBoxTimeHH.SelectedIndex = comboBoxTimeHH.FindStringExact(TimeElements[0]);    
                    comboBoxTimeMM.SelectedIndex = comboBoxTimeMM.FindStringExact(TimeElements[1]);                
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
 

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventPreview eventP = new EventPreview(this);
            DialogResult dr = eventP.ShowDialog(this);
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

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            if(VCBoxDropDown != null)
            {
                VCBoxDropDown(sender, e);
                
            }            
        }

        #endregion

        #region MyFunctions

        public bool AreComboboxesNotEmpty()
        {
            if(comboBoxDateD.SelectedIndex != -1 && comboBoxDateM.SelectedIndex != -1 &&
                comboBoxDateY.SelectedIndex != -1 && comboBoxTimeHH.SelectedIndex != -1 &&
                comboBoxTimeMM.SelectedIndex != -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveEvent()
        {
            listBoxEvents.Items.RemoveAt(SelectedIndex);
        }

        private void FillListBox()
        {
            foreach (var e in Org.eventList)
            {
                AddEvent(e);
            }

        }

        private bool IsNotEmpty(TextBox t)
        {
            if (t.Text == "")
            {
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
            comboBoxDateD.SelectedIndex = -1;
            comboBoxDateM.SelectedIndex = -1;
            comboBoxDateY.SelectedIndex = -1;
            comboBoxTimeHH.SelectedIndex = -1;
            comboBoxTimeMM.SelectedIndex = -1;
            textBoxPlace.Clear();
            textBoxOrganiser.Clear();
        }

        public void AddEvent(Event newEvent)
        {

            if (!listBoxEvents.Items.Contains(newEvent))
            {

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

        #endregion


    }
}
