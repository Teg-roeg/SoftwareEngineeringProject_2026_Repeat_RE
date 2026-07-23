namespace GymSystem
{
    partial class FormEditInstructor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuRegisterInstructor = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdInstructors = new System.Windows.Forms.DataGridView();
            this.grpInstructor = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.mnuRegisterInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructors)).BeginInit();
            this.grpInstructor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2.MinimumSize = new System.Drawing.Size(244, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Instructor:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(302, 119);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(373, 29);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(704, 119);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(259, 53);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // mnuRegisterInstructor
            // 
            this.mnuRegisterInstructor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mnuRegisterInstructor.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuRegisterInstructor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuRegisterInstructor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuRegisterInstructor.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterInstructor.Name = "mnuRegisterInstructor";
            this.mnuRegisterInstructor.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuRegisterInstructor.Size = new System.Drawing.Size(1446, 42);
            this.mnuRegisterInstructor.TabIndex = 8;
            this.mnuRegisterInstructor.Text = "menuStrip1";
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
            // grdInstructors
            // 
            this.grdInstructors.AllowUserToAddRows = false;
            this.grdInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInstructors.Location = new System.Drawing.Point(38, 188);
            this.grdInstructors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdInstructors.MultiSelect = false;
            this.grdInstructors.Name = "grdInstructors";
            this.grdInstructors.ReadOnly = true;
            this.grdInstructors.RowHeadersWidth = 62;
            this.grdInstructors.RowTemplate.Height = 28;
            this.grdInstructors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInstructors.Size = new System.Drawing.Size(1351, 234);
            this.grdInstructors.TabIndex = 9;
            this.grdInstructors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInstructorsCellClick);
            // 
            // grpInstructor
            // 
            this.grpInstructor.Controls.Add(this.label7);
            this.grpInstructor.Controls.Add(this.txtInstructorID);
            this.grpInstructor.Controls.Add(this.label6);
            this.grpInstructor.Controls.Add(this.txtSpeciality);
            this.grpInstructor.Controls.Add(this.btnUpdate);
            this.grpInstructor.Controls.Add(this.label5);
            this.grpInstructor.Controls.Add(this.txtPhone);
            this.grpInstructor.Controls.Add(this.label4);
            this.grpInstructor.Controls.Add(this.txtEmail);
            this.grpInstructor.Controls.Add(this.label3);
            this.grpInstructor.Controls.Add(this.txtLastName);
            this.grpInstructor.Controls.Add(this.label1);
            this.grpInstructor.Controls.Add(this.txtFirstName);
            this.grpInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstructor.Location = new System.Drawing.Point(38, 451);
            this.grpInstructor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInstructor.Name = "grpInstructor";
            this.grpInstructor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInstructor.Size = new System.Drawing.Size(1351, 598);
            this.grpInstructor.TabIndex = 10;
            this.grpInstructor.TabStop = false;
            this.grpInstructor.Text = "Edit Instructor Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label7.MinimumSize = new System.Drawing.Size(197, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Instructor ID:";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(264, 104);
            this.txtInstructorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInstructorID.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(266, 39);
            this.txtInstructorID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label6.MinimumSize = new System.Drawing.Size(197, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Speciality:";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(264, 377);
            this.txtSpeciality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpeciality.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(266, 39);
            this.txtSpeciality.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(864, 491);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(444, 82);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Edit Instructor";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(197, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(913, 289);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(376, 39);
            this.txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(197, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(264, 286);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(395, 39);
            this.txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label3.MinimumSize = new System.Drawing.Size(197, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(913, 197);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(376, 39);
            this.txtLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(197, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(264, 190);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(395, 39);
            this.txtFirstName.TabIndex = 3;
            // 
            // FormEditInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 1069);
            this.Controls.Add(this.grpInstructor);
            this.Controls.Add(this.grdInstructors);
            this.Controls.Add(this.mnuRegisterInstructor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditInstructor";
            this.Text = "Edit Instructor";
            this.mnuRegisterInstructor.ResumeLayout(false);
            this.mnuRegisterInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructors)).EndInit();
            this.grpInstructor.ResumeLayout(false);
            this.grpInstructor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip mnuRegisterInstructor;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdInstructors;
        private System.Windows.Forms.GroupBox grpInstructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSpeciality;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInstructorID;
    }
}