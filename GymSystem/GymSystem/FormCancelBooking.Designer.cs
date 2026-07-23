namespace GymSystem
{
    partial class FormCancelBooking
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
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.mnuCreateMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.grpBooking.SuspendLayout();
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
            this.mnuCreateMember.Size = new System.Drawing.Size(997, 42);
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
            this.backToolStripMenuItem.Click += new System.EventHandler(this.MenuBackClick);
            // 
            // grdBookings
            // 
            this.grdBookings.AllowUserToAddRows = false;
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdBookings.Location = new System.Drawing.Point(67, 133);
            this.grdBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdBookings.MultiSelect = false;
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.ReadOnly = true;
            this.grdBookings.RowHeadersWidth = 62;
            this.grdBookings.RowTemplate.Height = 28;
            this.grdBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBookings.Size = new System.Drawing.Size(849, 234);
            this.grdBookings.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(687, 66);
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
            this.label6.Location = new System.Drawing.Point(61, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label6.MinimumSize = new System.Drawing.Size(244, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search Booking:";
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.btnCancel);
            this.grpBooking.Controls.Add(this.label5);
            this.grpBooking.Controls.Add(this.label1);
            this.grpBooking.Controls.Add(this.txtStatus);
            this.grpBooking.Controls.Add(this.txtBookingID);
            this.grpBooking.Controls.Add(this.label4);
            this.grpBooking.Controls.Add(this.txtBookingDate);
            this.grpBooking.Controls.Add(this.label3);
            this.grpBooking.Controls.Add(this.txtClassID);
            this.grpBooking.Controls.Add(this.label2);
            this.grpBooking.Controls.Add(this.txtMemberID);
            this.grpBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooking.Location = new System.Drawing.Point(67, 386);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(849, 550);
            this.grpBooking.TabIndex = 22;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Enter Booking Details";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(171, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(471, 80);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.label5.Text = "Status:";
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
            this.label1.Text = "Booking ID:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(238, 349);
            this.txtStatus.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(229, 39);
            this.txtStatus.TabIndex = 9;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(239, 92);
            this.txtBookingID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(177, 39);
            this.txtBookingID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(179, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Booking Date:";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(238, 282);
            this.txtBookingDate.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(447, 39);
            this.txtBookingDate.TabIndex = 7;
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
            this.label3.Text = "Class ID:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(238, 219);
            this.txtClassID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(178, 39);
            this.txtClassID.TabIndex = 5;
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
            this.label2.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(238, 156);
            this.txtMemberID.MinimumSize = new System.Drawing.Size(133, 35);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(178, 39);
            this.txtMemberID.TabIndex = 3;
            // 
            // txtBooking
            // 
            this.txtBooking.Location = new System.Drawing.Point(323, 66);
            this.txtBooking.Margin = new System.Windows.Forms.Padding(4);
            this.txtBooking.MinimumSize = new System.Drawing.Size(146, 35);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(323, 35);
            this.txtBooking.TabIndex = 24;
            // 
            // FormCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 966);
            this.Controls.Add(this.mnuCreateMember);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.txtBooking);
            this.Name = "FormCancelBooking";
            this.Text = "Cancel Booking";
            this.mnuCreateMember.ResumeLayout(false);
            this.mnuCreateMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateMember;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtBooking;
    }
}