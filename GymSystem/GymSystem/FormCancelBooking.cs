using System;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormCancelBooking : Form
    {
        private MainForm parent;

        private Booking booking;

        public FormCancelBooking(MainForm Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdBookings.Visible = false;
            grpBooking.Visible = false;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();

            parent.Visible = true;
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a member name");
                txtSearch.Focus();
                return;
            }

            grdBookings.DataSource = Booking.FindBookings(txtSearch.Text.Trim()).Tables[0];

            if (grdBookings.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");

                grdBookings.Visible = false;
                grpBooking.Visible = false;

                txtSearch.Focus();
                return;
            }

            grdBookings.Visible = true;
            grpBooking.Visible = false;
        }

        private void GridBookingsCellClick(object sender,DataGridViewCellEventArgs e)
        {

            int bookingID = Convert.ToInt32(grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells[0].Value);

            booking = Booking.GetBookingByID(bookingID);

            txtBookingID.Text = booking.BookingID.ToString("0000");
            txtMemberID.Text = booking.MemberID.ToString("0000");
            txtClassID.Text = booking.ClassID.ToString("0000");
            txtBookingDate.Text = booking.BookingDate.ToShortDateString();
            txtStatus.Text = booking.Status;

            grpBooking.Visible = true;
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            if (booking == null)
            {
                MessageBox.Show("Please select a booking from the grid");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel booking " + booking.BookingID.ToString("0000") + "?","Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            booking.CancelBooking();

            MessageBox.Show("Booking Cancelled", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpBooking.Visible = false;
            grdBookings.Visible = false;

            txtSearch.Clear();
            txtBookingID.Clear();
            txtMemberID.Clear();
            txtClassID.Clear();
            txtBookingDate.Clear();
            txtStatus.Clear();

            txtSearch.Focus();
        }
    }
}
