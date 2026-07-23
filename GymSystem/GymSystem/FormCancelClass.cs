using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormCancelClass : Form
    {
        private MainForm parent;

        private GymClass gymClass;

        public FormCancelClass(MainForm Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdClasses.Visible = false;
            grpClass.Visible = false;
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a class name");
                txtSearch.Focus();
                return;
            }

            DataSet ds = GymClass.FindClasses(txtSearch.Text);

            grdClasses.DataSource = ds.Tables[0];


            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");

                grdClasses.Visible = false;
                grpClass.Visible = false;

                txtSearch.Focus();
                return;
            }



            grdClasses.Visible = true;
            grpClass.Visible = false;
        }


        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();

            parent.Visible = true;
        }

        private void GridClassesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int classID = Convert.ToInt32(grdClasses.Rows[grdClasses.CurrentCell.RowIndex].Cells[0].Value);

            gymClass = GymClass.GetClass(classID);

            txtClassID.Text = gymClass.ClassID.ToString("0000");
            txtClassName.Text = gymClass.ClassName;
            txtClassDate.Text = gymClass.ClassDate.ToShortDateString();
            txtClassTime.Text = gymClass.ClassTime;
            txtInstructorID.Text = gymClass.InstructorID.ToString("0000");
            txtRoomID.Text = gymClass.RoomID.ToString("000");
            txtCapacity.Text = gymClass.Capacity.ToString();

            grpClass.Visible = true;
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {

            if (gymClass == null)
            {
                MessageBox.Show("Please select a class from the grid");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel " + gymClass.ClassName + "?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            gymClass.CancelClass();

            MessageBox.Show("Class cancelled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpClass.Visible = false;
            grdClasses.Visible = false;

            txtSearch.Clear();
            txtClassID.Clear();
            txtClassName.Clear();
            txtClassDate.Clear();
            txtClassTime.Clear();
            txtInstructorID.Clear();
            txtRoomID.Clear();
            txtCapacity.Clear();

            txtSearch.Focus();
        }
    }
}
