namespace OperaHouse_Assignment5
{
    partial class frmOverview
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
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.chkOpenShows = new System.Windows.Forms.CheckBox();
            this.chkPerformer = new System.Windows.Forms.CheckBox();
            this.cbxPerfFilter = new System.Windows.Forms.ComboBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Performer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxStage = new System.Windows.Forms.ComboBox();
            this.cbxPerformer = new System.Windows.Forms.ComboBox();
            this.gbxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(17, 35);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(289, 342);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.Tag = "";
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grand Opera House Ticketing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.chkOpenShows);
            this.gbxFilter.Controls.Add(this.chkPerformer);
            this.gbxFilter.Controls.Add(this.cbxPerfFilter);
            this.gbxFilter.Location = new System.Drawing.Point(312, 86);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(199, 59);
            this.gbxFilter.TabIndex = 2;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // chkOpenShows
            // 
            this.chkOpenShows.AutoSize = true;
            this.chkOpenShows.Location = new System.Drawing.Point(6, 39);
            this.chkOpenShows.Name = "chkOpenShows";
            this.chkOpenShows.Size = new System.Drawing.Size(87, 17);
            this.chkOpenShows.TabIndex = 1;
            this.chkOpenShows.Text = "Open Shows";
            this.chkOpenShows.UseVisualStyleBackColor = true;
            this.chkOpenShows.CheckedChanged += new System.EventHandler(this.chkOpenShows_CheckedChanged);
            // 
            // chkPerformer
            // 
            this.chkPerformer.AutoSize = true;
            this.chkPerformer.Location = new System.Drawing.Point(6, 16);
            this.chkPerformer.Name = "chkPerformer";
            this.chkPerformer.Size = new System.Drawing.Size(71, 17);
            this.chkPerformer.TabIndex = 0;
            this.chkPerformer.Text = "Performer";
            this.chkPerformer.UseVisualStyleBackColor = true;
            this.chkPerformer.CheckedChanged += new System.EventHandler(this.chkPerformer_CheckedChanged);
            // 
            // cbxPerfFilter
            // 
            this.cbxPerfFilter.Enabled = false;
            this.cbxPerfFilter.FormattingEnabled = true;
            this.cbxPerfFilter.Location = new System.Drawing.Point(93, 12);
            this.cbxPerfFilter.Name = "cbxPerfFilter";
            this.cbxPerfFilter.Size = new System.Drawing.Size(100, 21);
            this.cbxPerfFilter.TabIndex = 22;
            this.cbxPerfFilter.SelectedIndexChanged += new System.EventHandler(this.cbxPerformer_SelectedIndexChanged);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(312, 57);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 3;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(393, 57);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(312, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(17, 383);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 20);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(61, 383);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 20);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(99, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 20);
            this.lblID.TabIndex = 8;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(99, 71);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stage:";
            // 
            // Performer
            // 
            this.Performer.AutoSize = true;
            this.Performer.Location = new System.Drawing.Point(5, 100);
            this.Performer.Name = "Performer";
            this.Performer.Size = new System.Drawing.Size(55, 13);
            this.Performer.TabIndex = 15;
            this.Performer.Text = "Performer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Duration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Event Time:";
            // 
            // dtpEventTime
            // 
            this.dtpEventTime.Location = new System.Drawing.Point(9, 190);
            this.dtpEventTime.Name = "dtpEventTime";
            this.dtpEventTime.Size = new System.Drawing.Size(190, 20);
            this.dtpEventTime.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Tickets:";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(136, 149);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(63, 20);
            this.txtTickets.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxStage);
            this.groupBox1.Controls.Add(this.cbxPerformer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpEventTime);
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Performer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(312, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 229);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Details";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(99, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Title:";
            // 
            // cbxStage
            // 
            this.cbxStage.FormattingEnabled = true;
            this.cbxStage.Location = new System.Drawing.Point(99, 122);
            this.cbxStage.Name = "cbxStage";
            this.cbxStage.Size = new System.Drawing.Size(100, 21);
            this.cbxStage.TabIndex = 22;
            // 
            // cbxPerformer
            // 
            this.cbxPerformer.FormattingEnabled = true;
            this.cbxPerformer.Location = new System.Drawing.Point(99, 97);
            this.cbxPerformer.Name = "cbxPerformer";
            this.cbxPerformer.Size = new System.Drawing.Size(100, 21);
            this.cbxPerformer.TabIndex = 22;
            this.cbxPerformer.SelectedIndexChanged += new System.EventHandler(this.cbxPerformer_SelectedIndexChanged);
            // 
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 415);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOverview";
            this.Text = "Grand Opera System";
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.CheckBox chkOpenShows;
        private System.Windows.Forms.CheckBox chkPerformer;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Performer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxStage;
        private System.Windows.Forms.ComboBox cbxPerformer;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPerfFilter;
    }
}