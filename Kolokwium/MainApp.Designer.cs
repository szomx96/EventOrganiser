namespace Kolokwium
{
    partial class MainApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelOrganiser = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxOrganiser = new System.Windows.Forms.TextBox();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.groupBoxNewEvent = new System.Windows.Forms.GroupBox();
            this.labelDateSep2 = new System.Windows.Forms.Label();
            this.comboBoxDateY = new System.Windows.Forms.ComboBox();
            this.labelDateSep1 = new System.Windows.Forms.Label();
            this.labelTimeSeparator = new System.Windows.Forms.Label();
            this.comboBoxDateM = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeMM = new System.Windows.Forms.ComboBox();
            this.comboBoxDateD = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxTimeHH = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wydarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxMyEvents = new System.Windows.Forms.GroupBox();
            this.groupBoxNewEvent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMyEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nazwa:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(34, 97);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Data:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(34, 139);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 17);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Godzina:";
            // 
            // labelOrganiser
            // 
            this.labelOrganiser.AutoSize = true;
            this.labelOrganiser.Location = new System.Drawing.Point(34, 226);
            this.labelOrganiser.Name = "labelOrganiser";
            this.labelOrganiser.Size = new System.Drawing.Size(87, 17);
            this.labelOrganiser.TabIndex = 3;
            this.labelOrganiser.Text = "Organizator:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(34, 184);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(59, 17);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Miejsce:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(137, 184);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(203, 22);
            this.textBoxPlace.TabIndex = 7;
            // 
            // textBoxOrganiser
            // 
            this.textBoxOrganiser.Location = new System.Drawing.Point(137, 226);
            this.textBoxOrganiser.Name = "textBoxOrganiser";
            this.textBoxOrganiser.Size = new System.Drawing.Size(203, 22);
            this.textBoxOrganiser.TabIndex = 8;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(249, 273);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(91, 28);
            this.buttonAddEvent.TabIndex = 10;
            this.buttonAddEvent.Text = "Dodaj";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(18, 52);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(496, 324);
            this.listBoxEvents.TabIndex = 11;
            this.listBoxEvents.DoubleClick += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // groupBoxNewEvent
            // 
            this.groupBoxNewEvent.Controls.Add(this.labelDateSep2);
            this.groupBoxNewEvent.Controls.Add(this.comboBoxDateY);
            this.groupBoxNewEvent.Controls.Add(this.labelDateSep1);
            this.groupBoxNewEvent.Controls.Add(this.labelTimeSeparator);
            this.groupBoxNewEvent.Controls.Add(this.comboBoxDateM);
            this.groupBoxNewEvent.Controls.Add(this.comboBoxTimeMM);
            this.groupBoxNewEvent.Controls.Add(this.comboBoxDateD);
            this.groupBoxNewEvent.Controls.Add(this.buttonSave);
            this.groupBoxNewEvent.Controls.Add(this.comboBoxTimeHH);
            this.groupBoxNewEvent.Controls.Add(this.labelName);
            this.groupBoxNewEvent.Controls.Add(this.labelDate);
            this.groupBoxNewEvent.Controls.Add(this.labelTime);
            this.groupBoxNewEvent.Controls.Add(this.labelOrganiser);
            this.groupBoxNewEvent.Controls.Add(this.buttonAddEvent);
            this.groupBoxNewEvent.Controls.Add(this.labelPlace);
            this.groupBoxNewEvent.Controls.Add(this.textBoxOrganiser);
            this.groupBoxNewEvent.Controls.Add(this.textBoxName);
            this.groupBoxNewEvent.Controls.Add(this.textBoxPlace);
            this.groupBoxNewEvent.Location = new System.Drawing.Point(12, 51);
            this.groupBoxNewEvent.Name = "groupBoxNewEvent";
            this.groupBoxNewEvent.Size = new System.Drawing.Size(362, 372);
            this.groupBoxNewEvent.TabIndex = 14;
            this.groupBoxNewEvent.TabStop = false;
            this.groupBoxNewEvent.Text = "Nowe wydarzenie";
            // 
            // labelDateSep2
            // 
            this.labelDateSep2.AutoSize = true;
            this.labelDateSep2.Location = new System.Drawing.Point(259, 96);
            this.labelDateSep2.Name = "labelDateSep2";
            this.labelDateSep2.Size = new System.Drawing.Size(13, 17);
            this.labelDateSep2.TabIndex = 22;
            this.labelDateSep2.Text = "-";
            // 
            // comboBoxDateY
            // 
            this.comboBoxDateY.FormattingEnabled = true;
            this.comboBoxDateY.Location = new System.Drawing.Point(275, 94);
            this.comboBoxDateY.Name = "comboBoxDateY";
            this.comboBoxDateY.Size = new System.Drawing.Size(65, 24);
            this.comboBoxDateY.TabIndex = 4;
            this.comboBoxDateY.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // labelDateSep1
            // 
            this.labelDateSep1.AutoSize = true;
            this.labelDateSep1.Location = new System.Drawing.Point(190, 96);
            this.labelDateSep1.Name = "labelDateSep1";
            this.labelDateSep1.Size = new System.Drawing.Size(13, 17);
            this.labelDateSep1.TabIndex = 21;
            this.labelDateSep1.Text = "-";
            // 
            // labelTimeSeparator
            // 
            this.labelTimeSeparator.AutoSize = true;
            this.labelTimeSeparator.Location = new System.Drawing.Point(233, 143);
            this.labelTimeSeparator.Name = "labelTimeSeparator";
            this.labelTimeSeparator.Size = new System.Drawing.Size(12, 17);
            this.labelTimeSeparator.TabIndex = 21;
            this.labelTimeSeparator.Text = ":";
            // 
            // comboBoxDateM
            // 
            this.comboBoxDateM.FormattingEnabled = true;
            this.comboBoxDateM.Location = new System.Drawing.Point(207, 94);
            this.comboBoxDateM.Name = "comboBoxDateM";
            this.comboBoxDateM.Size = new System.Drawing.Size(47, 24);
            this.comboBoxDateM.TabIndex = 3;
            this.comboBoxDateM.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // comboBoxTimeMM
            // 
            this.comboBoxTimeMM.FormattingEnabled = true;
            this.comboBoxTimeMM.Location = new System.Drawing.Point(259, 141);
            this.comboBoxTimeMM.Name = "comboBoxTimeMM";
            this.comboBoxTimeMM.Size = new System.Drawing.Size(81, 24);
            this.comboBoxTimeMM.TabIndex = 6;
            this.comboBoxTimeMM.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // comboBoxDateD
            // 
            this.comboBoxDateD.FormattingEnabled = true;
            this.comboBoxDateD.Location = new System.Drawing.Point(137, 94);
            this.comboBoxDateD.Name = "comboBoxDateD";
            this.comboBoxDateD.Size = new System.Drawing.Size(47, 24);
            this.comboBoxDateD.TabIndex = 2;
            this.comboBoxDateD.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(249, 307);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 28);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxTimeHH
            // 
            this.comboBoxTimeHH.FormattingEnabled = true;
            this.comboBoxTimeHH.Location = new System.Drawing.Point(137, 141);
            this.comboBoxTimeHH.Name = "comboBoxTimeHH";
            this.comboBoxTimeHH.Size = new System.Drawing.Size(81, 24);
            this.comboBoxTimeHH.TabIndex = 5;
            this.comboBoxTimeHH.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wydarzenieToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wydarzenieToolStripMenuItem
            // 
            this.wydarzenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.wydarzenieToolStripMenuItem.Name = "wydarzenieToolStripMenuItem";
            this.wydarzenieToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.wydarzenieToolStripMenuItem.Text = "Wydarzenie";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(431, 386);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(83, 31);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(342, 386);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(83, 31);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBoxMyEvents
            // 
            this.groupBoxMyEvents.Controls.Add(this.listBoxEvents);
            this.groupBoxMyEvents.Controls.Add(this.buttonRemove);
            this.groupBoxMyEvents.Controls.Add(this.buttonEdit);
            this.groupBoxMyEvents.Location = new System.Drawing.Point(397, 51);
            this.groupBoxMyEvents.Name = "groupBoxMyEvents";
            this.groupBoxMyEvents.Size = new System.Drawing.Size(536, 426);
            this.groupBoxMyEvents.TabIndex = 20;
            this.groupBoxMyEvents.TabStop = false;
            this.groupBoxMyEvents.Text = "Moje wydarzenia";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 498);
            this.Controls.Add(this.groupBoxMyEvents);
            this.Controls.Add(this.groupBoxNewEvent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "Form1";
            this.groupBoxNewEvent.ResumeLayout(false);
            this.groupBoxNewEvent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMyEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelOrganiser;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxOrganiser;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.GroupBox groupBoxNewEvent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wydarzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxMyEvents;
        private System.Windows.Forms.ComboBox comboBoxTimeHH;
        private System.Windows.Forms.ComboBox comboBoxTimeMM;
        private System.Windows.Forms.Label labelTimeSeparator;
        private System.Windows.Forms.ComboBox comboBoxDateD;
        private System.Windows.Forms.ComboBox comboBoxDateM;
        private System.Windows.Forms.ComboBox comboBoxDateY;
        private System.Windows.Forms.Label labelDateSep2;
        private System.Windows.Forms.Label labelDateSep1;
    }
}

