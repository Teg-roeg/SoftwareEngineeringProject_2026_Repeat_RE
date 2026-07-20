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
    }
}
