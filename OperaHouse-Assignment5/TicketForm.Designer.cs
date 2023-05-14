namespace OperaHouse_Assignment5
{
    partial class TicketForm
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeatCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbNotSold = new System.Windows.Forms.RadioButton();
            this.gbxPurchase = new System.Windows.Forms.GroupBox();
            this.gbxPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(12, 12);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(106, 82);
            this.lstTickets.TabIndex = 0;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.lstTickets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seat:";
            // 
            // txtSeatCode
            // 
            this.txtSeatCode.Location = new System.Drawing.Point(152, 10);
            this.txtSeatCode.Name = "txtSeatCode";
            this.txtSeatCode.Size = new System.Drawing.Size(64, 20);
            this.txtSeatCode.TabIndex = 5;
            this.txtSeatCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeatCode_KeyPress);
            this.txtSeatCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtSeatCode_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.Location = new System.Drawing.Point(6, 15);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(46, 17);
            this.rbSold.TabIndex = 7;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Sold";
            this.rbSold.UseVisualStyleBackColor = true;
            this.rbSold.CheckedChanged += new System.EventHandler(this.rbSold_CheckedChanged);
            // 
            // rbNotSold
            // 
            this.rbNotSold.AutoSize = true;
            this.rbNotSold.Location = new System.Drawing.Point(6, 38);
            this.rbNotSold.Name = "rbNotSold";
            this.rbNotSold.Size = new System.Drawing.Size(66, 17);
            this.rbNotSold.TabIndex = 7;
            this.rbNotSold.TabStop = true;
            this.rbNotSold.Text = "Not Sold";
            this.rbNotSold.UseVisualStyleBackColor = true;
            this.rbNotSold.CheckedChanged += new System.EventHandler(this.rbNotSold_CheckedChanged);
            // 
            // gbxPurchase
            // 
            this.gbxPurchase.Controls.Add(this.rbNotSold);
            this.gbxPurchase.Controls.Add(this.rbSold);
            this.gbxPurchase.Location = new System.Drawing.Point(125, 36);
            this.gbxPurchase.Name = "gbxPurchase";
            this.gbxPurchase.Size = new System.Drawing.Size(91, 61);
            this.gbxPurchase.TabIndex = 8;
            this.gbxPurchase.TabStop = false;
            this.gbxPurchase.Text = "Ticket Status";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 138);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSeatCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.gbxPurchase);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.gbxPurchase.ResumeLayout(false);
            this.gbxPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeatCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbNotSold;
        private System.Windows.Forms.GroupBox gbxPurchase;
    }
}