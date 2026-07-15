using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormCreateMember : Form
    {
        MainForm parent;

        public FormCreateMember()
        {
            InitializeComponent();
        }

        public FormCreateMember(MainForm Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void FormCreateMemberLoad(object sender, EventArgs e)
        {
            txtMemberID.Text = Member.GetNextMemberID().ToString("0000");

            txtFirstName.Focus();
        }

        private void ButtonCreateMemberClick(object sender, EventArgs e)
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


        }
    }
}
