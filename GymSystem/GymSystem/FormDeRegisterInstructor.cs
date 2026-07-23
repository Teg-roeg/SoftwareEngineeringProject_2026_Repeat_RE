using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormDeRegisterInstructor : Form
    {
        private MainForm parent;

        private Instructor instructor;


        public FormDeRegisterInstructor(MainForm Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdInstructors.Visible = false;
            grpInstructor.Visible = false;
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter an instructor name");
                txtSearch.Focus();
                return;
            }
        }

    }
}
