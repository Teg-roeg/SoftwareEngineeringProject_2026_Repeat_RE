using System;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuCreateMember(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateMember nextForm = new FormCreateMember(this);
            nextForm.Show();
        }

        private void MenuRegisterInstructor(object sender, EventArgs e)
        {
            this.Hide();
            FormRegisterInstructor nextForm = new FormRegisterInstructor(this);
            nextForm.Show();
        }

        private void MenuScheduleClass(object sender, EventArgs e)
        {
            this.Hide();
            FormScheduleClass nextForm = new FormScheduleClass(this);
            nextForm.Show();
        }

        private void MenuCreateBooking(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateBooking nextForm = new FormCreateBooking(this);
            nextForm.Show();
        }

        private void MenuEditInstructorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormEditInstructor nextForm = new FormEditInstructor(this);
            nextForm.Show();
        }

        private void MenuDeRegisterInstructorClick(object sender, EventArgs e)
        {
            this.Hide();
            FormDeRegisterInstructor nextForm = new FormDeRegisterInstructor(this);
            nextForm.Show();
        }

        private void MenuWithdrawMembershipClick(object sender, EventArgs e)
        {
            this.Hide();
            FormWithdrawMembership nextForm = new FormWithdrawMembership(this);
            nextForm.Show();
        }

        private void MenuCancelClassClick(object sender, EventArgs e)
        {
            this.Hide();
            FormCancelClass nextForm = new FormCancelClass(this);
            nextForm.Show();
        }

        private void MenuCancelBookingClick(object sender, EventArgs e)
        {
            this.Hide();
            FormCancelBooking nextForm = new FormCancelBooking(this);
            nextForm.Show();
        }
    }
}
