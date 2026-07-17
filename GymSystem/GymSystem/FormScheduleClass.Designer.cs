namespace GymSystem
{
    partial class FormScheduleClass
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
            this.mnuFormSchedule = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cboClassTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboInstructors = new System.Windows.Forms.ComboBox();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnScheduleClass = new System.Windows.Forms.Button();
            this.mnuFormSchedule.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuFormSchedule.Size = new System.Drawing.Size(1227, 38);
            this.mnuFormSchedule.TabIndex = 4;
            this.mnuFormSchedule.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.MenuBackClick);
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnScheduleClass);
            this.grpClass.Controls.Add(this.label9);
            this.grpClass.Controls.Add(this.txtCapacity);
            this.grpClass.Controls.Add(this.label8);
            this.grpClass.Controls.Add(this.cboRooms);
            this.grpClass.Controls.Add(this.label7);
            this.grpClass.Controls.Add(this.txtPrice);
            this.grpClass.Controls.Add(this.label6);
            this.grpClass.Controls.Add(this.txtClassTime);
            this.grpClass.Controls.Add(this.label5);
            this.grpClass.Controls.Add(this.dtpClassDate);
            this.grpClass.Controls.Add(this.label4);
            this.grpClass.Controls.Add(this.cboInstructors);
            this.grpClass.Controls.Add(this.label3);
            this.grpClass.Controls.Add(this.cboClassTypes);
            this.grpClass.Controls.Add(this.label2);
            this.grpClass.Controls.Add(this.txtClassName);
            this.grpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClass.Location = new System.Drawing.Point(49, 144);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(1133, 799);
            this.grpClass.TabIndex = 5;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Schedule Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(161, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class ID:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(207, 88);
            this.txtClassID.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(121, 35);
            this.txtClassID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.MinimumSize = new System.Drawing.Size(161, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(215, 101);
            this.txtClassName.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(420, 39);
            this.txtClassName.TabIndex = 8;
            // 
            // cboClassTypes
            // 
            this.cboClassTypes.FormattingEnabled = true;
            this.cboClassTypes.Location = new System.Drawing.Point(215, 182);
            this.cboClassTypes.Name = "cboClassTypes";
            this.cboClassTypes.Size = new System.Drawing.Size(367, 40);
            this.cboClassTypes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.MinimumSize = new System.Drawing.Size(161, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(161, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Instructors:";
            // 
            // cboInstructors
            // 
            this.cboInstructors.FormattingEnabled = true;
            this.cboInstructors.Location = new System.Drawing.Point(215, 256);
            this.cboInstructors.Name = "cboInstructors";
            this.cboInstructors.Size = new System.Drawing.Size(367, 40);
            this.cboInstructors.TabIndex = 12;
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Location = new System.Drawing.Point(217, 335);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(491, 39);
            this.dtpClassDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(161, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Class Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.MinimumSize = new System.Drawing.Size(161, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Class Time:";
            // 
            // txtClassTime
            // 
            this.txtClassTime.Location = new System.Drawing.Point(217, 418);
            this.txtClassTime.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtClassTime.Name = "txtClassTime";
            this.txtClassTime.Size = new System.Drawing.Size(155, 39);
            this.txtClassTime.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.MinimumSize = new System.Drawing.Size(161, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(217, 489);
            this.txtPrice.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 39);
            this.txtPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 563);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.MinimumSize = new System.Drawing.Size(161, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Rooms:";
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(217, 560);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(271, 40);
            this.cboRooms.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 625);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.MinimumSize = new System.Drawing.Size(161, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(217, 625);
            this.txtCapacity.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(155, 39);
            this.txtCapacity.TabIndex = 22;
            // 
            // btnScheduleClass
            // 
            this.btnScheduleClass.BackColor = System.Drawing.Color.Firebrick;
            this.btnScheduleClass.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScheduleClass.Location = new System.Drawing.Point(606, 702);
            this.btnScheduleClass.Name = "btnScheduleClass";
            this.btnScheduleClass.Size = new System.Drawing.Size(457, 77);
            this.btnScheduleClass.TabIndex = 24;
            this.btnScheduleClass.Text = "Schedule Class";
            this.btnScheduleClass.UseVisualStyleBackColor = false;
            this.btnScheduleClass.Click += new System.EventHandler(this.ButtonScheduleClassClick);
            // 
            // FormScheduleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 955);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.mnuFormSchedule);
            this.Name = "FormScheduleClass";
            this.Text = "Schedule Class";
            this.Load += new System.EventHandler(this.FormScheduleClassLoad);
            this.mnuFormSchedule.ResumeLayout(false);
            this.mnuFormSchedule.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFormSchedule;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClassTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboInstructors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnScheduleClass;
    }
}