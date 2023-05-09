namespace OperaHouse_Assignment4
{
    partial class Form1
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
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.cbPerformer = new System.Windows.Forms.CheckBox();
            this.cbOpenShows = new System.Windows.Forms.CheckBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Performer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.Location = new System.Drawing.Point(17, 57);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(289, 368);
            this.listbox1.TabIndex = 0;
            this.listbox1.Tag = "lstEvent";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grand Oprea House Ticketing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.cbOpenShows);
            this.gbxFilter.Controls.Add(this.cbPerformer);
            this.gbxFilter.Location = new System.Drawing.Point(396, 118);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(200, 119);
            this.gbxFilter.TabIndex = 2;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // cbPerformer
            // 
            this.cbPerformer.AutoSize = true;
            this.cbPerformer.Location = new System.Drawing.Point(7, 36);
            this.cbPerformer.Name = "cbPerformer";
            this.cbPerformer.Size = new System.Drawing.Size(71, 17);
            this.cbPerformer.TabIndex = 0;
            this.cbPerformer.Text = "Performer";
            this.cbPerformer.UseVisualStyleBackColor = true;
            // 
            // cbOpenShows
            // 
            this.cbOpenShows.AutoSize = true;
            this.cbOpenShows.Location = new System.Drawing.Point(7, 71);
            this.cbOpenShows.Name = "cbOpenShows";
            this.cbOpenShows.Size = new System.Drawing.Size(87, 17);
            this.cbOpenShows.TabIndex = 1;
            this.cbOpenShows.Text = "Open Shows";
            this.cbOpenShows.UseVisualStyleBackColor = true;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(413, 61);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 3;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(494, 61);
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
            this.label2.Location = new System.Drawing.Point(473, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(77, 431);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(38, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(121, 431);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(506, 324);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 8;
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(506, 433);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(100, 20);
            this.txtStage.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(506, 353);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(506, 379);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // txtPerformer
            // 
            this.txtPerformer.Location = new System.Drawing.Point(506, 405);
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(100, 20);
            this.txtPerformer.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stage:";
            // 
            // Performer
            // 
            this.Performer.AutoSize = true;
            this.Performer.Location = new System.Drawing.Point(393, 405);
            this.Performer.Name = "Performer";
            this.Performer.Size = new System.Drawing.Size(55, 13);
            this.Performer.TabIndex = 15;
            this.Performer.Text = "Performer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Duration:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Event Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Tickets:";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(506, 459);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(100, 20);
            this.txtTickets.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 536);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Performer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPerformer);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtStage);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.CheckBox cbOpenShows;
        private System.Windows.Forms.CheckBox cbPerformer;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Performer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTickets;
    }
}