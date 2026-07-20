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

        public FormEditInstructor()
        {
            InitializeComponent();
        }

        public FormEditInstructor(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
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
    }
}
