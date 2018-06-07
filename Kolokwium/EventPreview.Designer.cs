namespace Kolokwium
{
    partial class EventPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelOrganiser = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.groupBoxEventPreview = new System.Windows.Forms.GroupBox();
            this.labelOrganiserValue = new System.Windows.Forms.Label();
            this.labelPlaceValue = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.groupBoxEventPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nazwa:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 102);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Data:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(16, 144);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 17);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Godzina:";
            // 
            // labelOrganiser
            // 
            this.labelOrganiser.AutoSize = true;
            this.labelOrganiser.Location = new System.Drawing.Point(16, 231);
            this.labelOrganiser.Name = "labelOrganiser";
            this.labelOrganiser.Size = new System.Drawing.Size(87, 17);
            this.labelOrganiser.TabIndex = 8;
            this.labelOrganiser.Text = "Organizator:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(16, 189);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(59, 17);
            this.labelPlace.TabIndex = 9;
            this.labelPlace.Text = "Miejsce:";
            // 
            // groupBoxEventPreview
            // 
            this.groupBoxEventPreview.Controls.Add(this.labelOrganiserValue);
            this.groupBoxEventPreview.Controls.Add(this.labelPlaceValue);
            this.groupBoxEventPreview.Controls.Add(this.labelTimeValue);
            this.groupBoxEventPreview.Controls.Add(this.labelDateValue);
            this.groupBoxEventPreview.Controls.Add(this.labelNameValue);
            this.groupBoxEventPreview.Controls.Add(this.labelName);
            this.groupBoxEventPreview.Controls.Add(this.labelPlace);
            this.groupBoxEventPreview.Controls.Add(this.labelDate);
            this.groupBoxEventPreview.Controls.Add(this.labelOrganiser);
            this.groupBoxEventPreview.Controls.Add(this.labelTime);
            this.groupBoxEventPreview.Location = new System.Drawing.Point(12, 22);
            this.groupBoxEventPreview.Name = "groupBoxEventPreview";
            this.groupBoxEventPreview.Size = new System.Drawing.Size(510, 337);
            this.groupBoxEventPreview.TabIndex = 10;
            this.groupBoxEventPreview.TabStop = false;
            this.groupBoxEventPreview.Text = "Podgląd";
            // 
            // labelOrganiserValue
            // 
            this.labelOrganiserValue.AutoSize = true;
            this.labelOrganiserValue.Location = new System.Drawing.Point(125, 231);
            this.labelOrganiserValue.Name = "labelOrganiserValue";
            this.labelOrganiserValue.Size = new System.Drawing.Size(46, 17);
            this.labelOrganiserValue.TabIndex = 14;
            this.labelOrganiserValue.Text = "label5";
            // 
            // labelPlaceValue
            // 
            this.labelPlaceValue.AutoSize = true;
            this.labelPlaceValue.Location = new System.Drawing.Point(125, 189);
            this.labelPlaceValue.Name = "labelPlaceValue";
            this.labelPlaceValue.Size = new System.Drawing.Size(46, 17);
            this.labelPlaceValue.TabIndex = 13;
            this.labelPlaceValue.Text = "label4";
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Location = new System.Drawing.Point(125, 144);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(46, 17);
            this.labelTimeValue.TabIndex = 12;
            this.labelTimeValue.Text = "label3";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Location = new System.Drawing.Point(125, 102);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(46, 17);
            this.labelDateValue.TabIndex = 11;
            this.labelDateValue.Text = "label2";
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(125, 57);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(46, 17);
            this.labelNameValue.TabIndex = 10;
            this.labelNameValue.Text = "label1";
            // 
            // EventPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 384);
            this.Controls.Add(this.groupBoxEventPreview);
            this.Name = "EventPreview";
            this.Text = "EventPreview";
            this.Load += new System.EventHandler(this.EventPreview_Load);
            this.groupBoxEventPreview.ResumeLayout(false);
            this.groupBoxEventPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelOrganiser;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.GroupBox groupBoxEventPreview;
        private System.Windows.Forms.Label labelOrganiserValue;
        private System.Windows.Forms.Label labelPlaceValue;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelNameValue;
    }
}