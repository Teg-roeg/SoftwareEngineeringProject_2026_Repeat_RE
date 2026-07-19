using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormCreateBooking : Form
    {
        MainForm parent;

        public FormCreateBooking()
        {
            InitializeComponent();
        }

        public FormCreateBooking(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormCreateBookingLoad(object sender, EventArgs e)
        {
            txtBookingID.Text = Booking.GetNextBookingID().ToString("0000");

            DataSet dsMembers = Member.GetActiveMembers();

            cboMembers.Items.Clear();

            for (int i = 0; i < dsMembers.Tables[0].Rows.Count; i++)
            {
                cboMembers.Items.Add(dsMembers.Tables[0].Rows[i][0] + " - " +
                                     dsMembers.Tables[0].Rows[i][1] + " " + dsMembers.Tables[0].Rows[i][2]);
            }

            DataSet dsClasses = GymClass.GetScheduledClasses();

            cboClasses.Items.Clear();

            for (int i = 0; i < dsClasses.Tables[0].Rows.Count; i++)
            {
                DateTime classDate = Convert.ToDateTime(dsClasses.Tables[0].Rows[i][4]);

                cboClasses.Items.Add(dsClasses.Tables[0].Rows[i][0] + " - " +
                                     dsClasses.Tables[0].Rows[i][1] + " - " +
                                     classDate.ToShortDateString() + " - " + dsClasses.Tables[0].Rows[i][5]);
            }
        }

        private void ButtonCreateBookingClick(object sender, EventArgs e)
        {
            if (cboMembers.SelectedIndex == -1)
            {
                MessageBox.Show("Member must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMembers.Focus();
                return;
            }

            if (cboClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Class must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClasses.Focus();
                return;
            }

            int memberID = Convert.ToInt32(cboMembers.Text.Substring(0, cboMembers.Text.IndexOf(" - ")));

            int classID = Convert.ToInt32(cboClasses.Text.Substring(0, cboClasses.Text.IndexOf(" - ")));

            Booking aBooking = new Booking(Convert.ToInt32(txtBookingID.Text), memberID, classID, DateTime.Today, "BOOKED" );

            try
            {
                aBooking.AddBooking();

                MessageBox.Show("Booking " + txtBookingID.Text + " created successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookingID.Text = Booking.GetNextBookingID().ToString("0000");
                cboMembers.SelectedIndex = -1;
                cboClasses.SelectedIndex = -1;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}