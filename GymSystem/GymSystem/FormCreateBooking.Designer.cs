namespace GymSystem
{
    partial class FormCreateBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMembers = new System.Windows.Forms.ComboBox();
            this.mnuFormSchedule = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClass.SuspendLayout();
            this.mnuFormSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(197, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Booking ID:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(258, 98);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingID.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(196, 29);
            this.txtBookingID.TabIndex = 9;
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnCreateBooking);
            this.grpClass.Controls.Add(this.label8);
            this.grpClass.Controls.Add(this.cboClasses);
            this.grpClass.Controls.Add(this.label4);
            this.grpClass.Controls.Add(this.cboMembers);
            this.grpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClass.Location = new System.Drawing.Point(64, 162);
            this.grpClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClass.Name = "grpClass";
            this.grpClass.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClass.Size = new System.Drawing.Size(731, 700);
            this.grpClass.TabIndex = 8;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Schedule Class";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreateBooking.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateBooking.Location = new System.Drawing.Point(54, 535);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(559, 92);
            this.btnCreateBooking.TabIndex = 24;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.ButtonCreateBookingClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label8.MinimumSize = new System.Drawing.Size(197, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Classes:";
            // 
            // cboClasses
            // 
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(259, 200);
            this.cboClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(352, 40);
            this.cboClasses.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(197, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Members:";
            // 
            // cboMembers
            // 
            this.cboMembers.FormattingEnabled = true;
            this.cboMembers.Location = new System.Drawing.Point(259, 97);
            this.cboMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Size = new System.Drawing.Size(352, 40);
            this.cboMembers.TabIndex = 12;
            // 
            // mnuFormSchedule
            // 
            this.mnuFormSchedule.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mnuFormSchedule.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuFormSchedule.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuFormSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuFormSchedule.Location = new System.Drawing.Point(0, 0);
            this.mnuFormSchedule.Name = "mnuFormSchedule";
            this.mnuFormSchedule.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuFormSchedule.Size = new System.Drawing.Size(864, 42);
            this.mnuFormSchedule.TabIndex = 11;
            this.mnuFormSchedule.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.MenuBackClick);
            // 
            // FormCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 876);
            this.Controls.Add(this.mnuFormSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.grpClass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreateBooking";
            this.Text = "Create Booking";
            this.Load += new System.EventHandler(this.FormCreateBookingLoad);
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.mnuFormSchedule.ResumeLayout(false);
            this.mnuFormSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMembers;
        private System.Windows.Forms.MenuStrip mnuFormSchedule;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}