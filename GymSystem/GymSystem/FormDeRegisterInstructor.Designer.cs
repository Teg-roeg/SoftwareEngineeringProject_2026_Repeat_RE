namespace GymSystem
{
    partial class FormDeRegisterInstructor
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
            this.grdInstructors = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpInstructor = new System.Windows.Forms.GroupBox();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.mnuCreateMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructors)).BeginInit();
            this.grpInstructor.SuspendLayout();
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
            this.mnuCreateMember.Size = new System.Drawing.Size(1345, 42);
            this.mnuCreateMember.TabIndex = 17;
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
            // grdInstructors
            // 
            this.grdInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInstructors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdInstructors.Location = new System.Drawing.Point(80, 177);
            this.grdInstructors.Margin = new System.Windows.Forms.Padding(4);
            this.grdInstructors.Name = "grdInstructors";
            this.grdInstructors.RowHeadersWidth = 62;
            this.grdInstructors.RowTemplate.Height = 28;
            this.grdInstructors.Size = new System.Drawing.Size(1184, 234);
            this.grdInstructors.TabIndex = 21;
            this.grdInstructors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInstructorsCellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(700, 110);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(229, 39);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label6.MinimumSize = new System.Drawing.Size(244, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search Member:";
            // 
            // grpInstructor
            // 
            this.grpInstructor.Controls.Add(this.label7);
            this.grpInstructor.Controls.Add(this.txtSpeciality);
            this.grpInstructor.Controls.Add(this.btnDeRegister);
            this.grpInstructor.Controls.Add(this.label5);
            this.grpInstructor.Controls.Add(this.label1);
            this.grpInstructor.Controls.Add(this.txtPhone);
            this.grpInstructor.Controls.Add(this.txtInstructorID);
            this.grpInstructor.Controls.Add(this.label4);
            this.grpInstructor.Controls.Add(this.txtEmail);
            this.grpInstructor.Controls.Add(this.label3);
            this.grpInstructor.Controls.Add(this.txtLastName);
            this.grpInstructor.Controls.Add(this.label2);
            this.grpInstructor.Controls.Add(this.txtFirstName);
            this.grpInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstructor.Location = new System.Drawing.Point(80, 430);
            this.grpInstructor.Name = "grpInstructor";
            this.grpInstructor.Size = new System.Drawing.Size(1184, 573);
            this.grpInstructor.TabIndex = 16;
            this.grpInstructor.TabStop = false;
            this.grpInstructor.Text = "Enter Member Details";
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.BackColor = System.Drawing.Color.Chocolate;
            this.btnDeRegister.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeRegister.Location = new System.Drawing.Point(736, 479);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(417, 73);
            this.btnDeRegister.TabIndex = 11;
            this.btnDeRegister.Text = "Deregister Instructor";
            this.btnDeRegister.UseVisualStyleBackColor = false;
            this.btnDeRegister.Click += new System.EventHandler(this.ButtonDeRegisterClick);
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
            this.label5.Text = "Phone:";
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
            this.label1.Text = "Member ID:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(224, 349);
            this.txtPhone.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(327, 39);
            this.txtPhone.TabIndex = 9;
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(225, 92);
            this.txtInstructorID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(177, 39);
            this.txtInstructorID.TabIndex = 4;
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
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(224, 282);
            this.txtEmail.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(414, 39);
            this.txtEmail.TabIndex = 7;
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
            this.label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(224, 219);
            this.txtLastName.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(360, 39);
            this.txtLastName.TabIndex = 5;
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
            this.label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(224, 156);
            this.txtFirstName.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(360, 39);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(336, 110);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 35);
            this.txtSearch.TabIndex = 18;
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
            this.label7.Text = "Speciality:";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(225, 416);
            this.txtSpeciality.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(327, 39);
            this.txtSpeciality.TabIndex = 12;
            // 
            // FormDeRegisterInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 1015);
            this.Controls.Add(this.mnuCreateMember);
            this.Controls.Add(this.grdInstructors);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpInstructor);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormDeRegisterInstructor";
            this.Text = "FormDeRegisterInstructor";
            this.mnuCreateMember.ResumeLayout(false);
            this.mnuCreateMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstructors)).EndInit();
            this.grpInstructor.ResumeLayout(false);
            this.grpInstructor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateMember;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdInstructors;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpInstructor;
        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpeciality;
    }
}