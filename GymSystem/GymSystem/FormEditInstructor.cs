using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymSystem
{
    public partial class FormEditInstructor : Form
    {
        private MainForm parent;

        private Instructor instructor;

        public FormEditInstructor(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
            grdInstructors.Visible = false;
            grpInstructor.Visible = false;
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
                MessageBox.Show("Enter an instructor name");
                txtSearch.Focus();
                return;
            }

            grdInstructors.DataSource = Instructor.FindInstructors(txtSearch.Text).Tables[0];

            if (grdInstructors.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }

            grdInstructors.Visible = true;
        }

        private void GridInstructorsCellClick(object sender, DataGridViewCellEventArgs e)
        {

            int InstructorId = Convert.ToInt32(grdInstructors.Rows[grdInstructors.CurrentCell.RowIndex].Cells[0].Value);


            instructor = Instructor.GetInstructor(InstructorId);


            txtFirstName.Text = instructor.FirstName;
            txtLastName.Text = instructor.LastName;
            txtEmail.Text = instructor.Email;
            txtPhone.Text = instructor.Phone;
            txtSpeciality.Text = instructor.Speciality;

            grpInstructor.Visible = true;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (instructor == null)
            {
                MessageBox.Show("Select an instructor from the grid");
                return;
            }

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First name must be entered");
                txtFirstName.Focus();
                return;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last name must be entered");
                txtLastName.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email must be entered");
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone must be entered");
                txtPhone.Focus();
                return;
            }

            if (txtSpeciality.Text == "")
            {
                MessageBox.Show("Speciality must be entered");
                txtSpeciality.Focus();
                return;
            }

            instructor.FirstName = txtFirstName.Text.Trim();
            instructor.LastName = txtLastName.Text.Trim();
            instructor.Email = txtEmail.Text.Trim();
            instructor.Phone = txtPhone.Text.Trim();
            instructor.Speciality = txtSpeciality.Text.Trim();

            instructor.UpdateInstructor();

            MessageBox.Show("Instructor Updated","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            grpInstructor.Visible = false;
            grdInstructors.Visible = false;

            txtSearch.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSpeciality.Clear();

            instructor = null;

            txtSearch.Focus();
        }
    }
}
