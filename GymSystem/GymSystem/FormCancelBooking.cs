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
    }
}
