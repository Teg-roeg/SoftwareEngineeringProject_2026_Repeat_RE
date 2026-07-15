using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GymSystem
{
    public partial class FormRegisterInstructor : Form
    {
        MainForm parent;

        public FormRegisterInstructor()
        {
            InitializeComponent();
        }

        public FormRegisterInstructor(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormRegisterInstructor_Load(object sender, EventArgs e)
        {
            txtInstructorID.Text = Instructor.GetNextInstructorID().ToString("0000");

            txtFirstName.Focus();
        }

        private void ButtonRegisterMemberClick(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First name must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last name must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (txtSpeciality.Text == "")
            {
                MessageBox.Show("Speciality must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpeciality.Focus();
                return;
            }

            Instructor anInstructor = new Instructor(
                Convert.ToInt32(txtInstructorID.Text),
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhone.Text,
                txtSpeciality.Text,
                "ACTIVE"
            );

            anInstructor.AddInstructor();

            MessageBox.Show("Instructor registered successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtInstructorID.Text = Instructor.GetNextInstructorID().ToString("0000");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSpeciality.Clear();
            txtFirstName.Focus();
        }
    }
}
