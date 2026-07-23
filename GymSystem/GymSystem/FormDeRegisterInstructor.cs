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

            DataSet ds = Instructor.FindInstructors(txtSearch.Text);

            grdInstructors.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");

                grdInstructors.Visible = false;
                grpInstructor.Visible = false;

                txtSearch.Focus();
                return;
            }

            grdInstructors.Visible = true;
            grpInstructor.Visible = false;
        }

        private void GridInstructorsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int instructorID = Convert.ToInt32(grdInstructors.Rows[grdInstructors.CurrentCell.RowIndex].Cells[0].Value);

            instructor = Instructor.GetInstructor(instructorID);

            txtInstructorID.Text = instructor.InstructorID.ToString("0000");

            txtFirstName.Text = instructor.FirstName;
            txtLastName.Text = instructor.LastName;
            txtEmail.Text = instructor.Email;
            txtPhone.Text = instructor.Phone;
            txtSpeciality.Text = instructor.Speciality;

            grpInstructor.Visible = true;
        }

        private void ButtonDeRegisterClick(object sender, EventArgs e)
        {
            if (instructor == null)
            {
                MessageBox.Show("Please select an instructor from the grid");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to deregister " +instructor.FirstName + " " + instructor.LastName + "?", "Confirm De-Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            instructor.DeRegisterInstructor();

            MessageBox.Show("Instructor de-registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpInstructor.Visible = false;
            grdInstructors.Visible = false;

            txtSearch.Clear();
            txtInstructorID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSpeciality.Clear();

            txtSearch.Focus();
        }
    }
}
