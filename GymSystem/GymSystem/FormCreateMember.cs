using System;
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

            Member aMember = new Member( Convert.ToInt32(txtMemberID.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, "ACTIVE" );

            aMember.AddMember();

            MessageBox.Show("Member " + txtMemberID.Text + " created successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMemberID.Text = Member.GetNextMemberID().ToString("0000");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtFirstName.Focus();
        }
    }
}
