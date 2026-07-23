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
    }
}
