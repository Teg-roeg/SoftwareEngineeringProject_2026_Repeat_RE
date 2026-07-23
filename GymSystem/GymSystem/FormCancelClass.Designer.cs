namespace GymSystem
{
    partial class FormCancelClass
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
            this.mnuCreateMember = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdClasses = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClassTime = new System.Windows.Forms.TextBox();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassDate = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.mnuCreateMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).BeginInit();
            this.grpClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCreateMember
            // 
            this.mnuCreateMember.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mnuCreateMember.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuCreateMember.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuCreateMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuCreateMember.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateMember.Name = "mnuCreateMember";
            this.mnuCreateMember.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mnuCreateMember.Size = new System.Drawing.Size(1425, 42);
            this.mnuCreateMember.TabIndex = 23;
            this.mnuCreateMember.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // grdClasses
            // 
            this.grdClasses.AllowUserToAddRows = false;
            this.grdClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClasses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdClasses.Location = new System.Drawing.Point(80, 137);
            this.grdClasses.Margin = new System.Windows.Forms.Padding(4);
            this.grdClasses.MultiSelect = false;
            this.grdClasses.Name = "grdClasses";
            this.grdClasses.ReadOnly = true;
            this.grdClasses.RowHeadersWidth = 62;
            this.grdClasses.RowTemplate.Height = 28;
            this.grdClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClasses.Size = new System.Drawing.Size(1281, 266);
            this.grdClasses.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(700, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(229, 39);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label6.MinimumSize = new System.Drawing.Size(244, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search Class:";
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.label10);
            this.grpClass.Controls.Add(this.txtCapacity);
            this.grpClass.Controls.Add(this.txtRoomID);
            this.grpClass.Controls.Add(this.label9);
            this.grpClass.Controls.Add(this.label8);
            this.grpClass.Controls.Add(this.txtPrice);
            this.grpClass.Controls.Add(this.label7);
            this.grpClass.Controls.Add(this.txtClassTime);
            this.grpClass.Controls.Add(this.btnDeRegister);
            this.grpClass.Controls.Add(this.label5);
            this.grpClass.Controls.Add(this.label1);
            this.grpClass.Controls.Add(this.txtClassDate);
            this.grpClass.Controls.Add(this.txtClassID);
            this.grpClass.Controls.Add(this.label4);
            this.grpClass.Controls.Add(this.txtInstructorID);
            this.grpClass.Controls.Add(this.label3);
            this.grpClass.Controls.Add(this.txtTypeCode);
            this.grpClass.Controls.Add(this.label2);
            this.grpClass.Controls.Add(this.txtClassName);
            this.grpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClass.Location = new System.Drawing.Point(80, 410);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(1281, 508);
            this.grpClass.TabIndex = 22;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Enter Class Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.MinimumSize = new System.Drawing.Size(179, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Class Time:";
            // 
            // txtClassTime
            // 
            this.txtClassTime.Location = new System.Drawing.Point(225, 416);
            this.txtClassTime.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtClassTime.Name = "txtClassTime";
            this.txtClassTime.Size = new System.Drawing.Size(327, 39);
            this.txtClassTime.TabIndex = 12;
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeRegister.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeRegister.Location = new System.Drawing.Point(718, 382);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(502, 73);
            this.btnDeRegister.TabIndex = 11;
            this.btnDeRegister.Text = "Cancel Class";
            this.btnDeRegister.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(179, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(179, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class ID:";
            // 
            // txtClassDate
            // 
            this.txtClassDate.Location = new System.Drawing.Point(224, 349);
            this.txtClassDate.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.Size = new System.Drawing.Size(327, 39);
            this.txtClassDate.TabIndex = 9;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(225, 92);
            this.txtClassID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(133, 39);
            this.txtClassID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(179, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Instructor ID:";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(224, 282);
            this.txtInstructorID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(134, 39);
            this.txtInstructorID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.MinimumSize = new System.Drawing.Size(179, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type Code:";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Location = new System.Drawing.Point(224, 219);
            this.txtTypeCode.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(360, 39);
            this.txtTypeCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.MinimumSize = new System.Drawing.Size(179, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(224, 156);
            this.txtClassName.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(360, 39);
            this.txtClassName.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(336, 70);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 35);
            this.txtSearch.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.MinimumSize = new System.Drawing.Size(179, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(819, 92);
            this.txtPrice.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 39);
            this.txtPrice.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.MinimumSize = new System.Drawing.Size(179, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Room ID:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(819, 156);
            this.txtRoomID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(133, 39);
            this.txtRoomID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.MinimumSize = new System.Drawing.Size(179, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(819, 219);
            this.txtCapacity.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(159, 39);
            this.txtCapacity.TabIndex = 19;
            // 
            // FormCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 930);
            this.Controls.Add(this.mnuCreateMember);
            this.Controls.Add(this.grdClasses);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormCancelClass";
            this.Text = "FormCancelClass";
            this.mnuCreateMember.ResumeLayout(false);
            this.mnuCreateMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).EndInit();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateMember;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdClasses;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassTime;
        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassDate;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCapacity;
    }
}