using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormScheduleClass : Form
    {
        MainForm parent;

        public FormScheduleClass()
        {
            InitializeComponent();
        }

        public FormScheduleClass(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormScheduleClassLoad(object sender, EventArgs e)
        {
            txtClassID.Text = GymClass.GetNextClassID().ToString("0000");

            DataSet dsTypes = ClassType.GetClassTypes();

            cboClassTypes.Items.Clear();

            for (int i = 0; i < dsTypes.Tables[0].Rows.Count; i++)
            {
                cboClassTypes.Items.Add(dsTypes.Tables[0].Rows[i][0] + " - " +
                                        dsTypes.Tables[0].Rows[i][1]);
            }

            DataSet dsInstructors = Instructor.GetActiveInstructors();

            cboInstructors.Items.Clear();

            for (int i = 0; i < dsInstructors.Tables[0].Rows.Count; i++)
            {
                cboInstructors.Items.Add(dsInstructors.Tables[0].Rows[i][0] + " - " +
                                         dsInstructors.Tables[0].Rows[i][1] + " " + dsInstructors.Tables[0].Rows[i][2]);
            }

            DataSet dsRooms = Room.GetRooms();

            cboRooms.Items.Clear();

            for (int i = 0; i < dsRooms.Tables[0].Rows.Count; i++)
            {
                cboRooms.Items.Add(dsRooms.Tables[0].Rows[i][0] + " - " + dsRooms.Tables[0].Rows[i][1]);
            }

            txtPrice.Text = "0.00";
            txtCapacity.Text = "0";
            txtClassName.Focus();
        }

        private void ButtonScheduleClassClick(object sender, EventArgs e)
        {
            if (txtClassName.Text == "")
            {
                MessageBox.Show("Class name must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
                return;
            }

            if (cboClassTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Class type must be selected", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClassTypes.Focus();
                return;
            }

            if (cboInstructors.SelectedIndex == -1)
            {
                MessageBox.Show("Instructor must be selected", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboInstructors.Focus();
                return;
            }

            if (txtClassTime.Text == "")
            {
                MessageBox.Show("Class time must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassTime.Focus();
                return;
            }

            if (cboRooms.SelectedIndex == -1)
            {
                MessageBox.Show("Room must be selected", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRooms.Focus();
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a valid number greater than zero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            int capacity;
            if (!int.TryParse(txtCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be a valid number greater than zero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacity.Focus();
                return;
            }

            string typeCode = cboClassTypes.Text.Substring(0, 2);

            int instructorID = Convert.ToInt32(
                cboInstructors.Text.Substring(0, cboInstructors.Text.IndexOf(" - "))
            );

            int roomID = Convert.ToInt32(
                cboRooms.Text.Substring(0, cboRooms.Text.IndexOf(" - "))
            );

            GymClass aClass = new GymClass(Convert.ToInt32(txtClassID.Text), txtClassName.Text, typeCode, instructorID, dtpClassDate.Value, txtClassTime.Text, price, roomID, capacity, "SCHEDULED" );

            try
            {
                aClass.AddClass();

                MessageBox.Show("Class " + txtClassID.Text + " scheduled successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtClassID.Text = GymClass.GetNextClassID().ToString("0000");
                txtClassName.Clear();
                cboClassTypes.SelectedIndex = -1;
                cboInstructors.SelectedIndex = -1;
                txtClassTime.Clear();
                txtPrice.Text = "0.00";
                cboRooms.SelectedIndex = -1;
                txtCapacity.Text = "0";
                txtClassName.Focus();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling class: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}