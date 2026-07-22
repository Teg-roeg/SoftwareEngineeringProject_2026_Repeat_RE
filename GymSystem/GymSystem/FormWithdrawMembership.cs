using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormWithdrawMembership : Form
    {
        private MainForm parent;

        private Member member;


        public FormWithdrawMembership(MainForm Parent)
        {
            InitializeComponent();

            parent = Parent;

            grdMembers.Visible = false;
            grpMember.Visible = false;
        }

        private void MenuBackClick(object sender, EventArgs e)
        {
            this.Close();

            parent.Visible = true;
        }

        private void GridMembersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int memberID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);

            member = Member.GetMember(memberID);

            txtMemberID.Text = member.MemberID.ToString("0000");
            txtFirstName.Text = member.FirstName;
            txtLastName.Text = member.LastName;
            txtEmail.Text = member.Email;
            txtPhone.Text = member.Phone;

            grpMember.Visible = true;
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a member name");
                txtSearch.Focus();
                return;
            }

            DataSet ds = Member.FindMembers(txtSearch.Text.Trim());

            grdMembers.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");

                grdMembers.Visible = false;
                grpMember.Visible = false;

                txtSearch.Focus();
                return;
            }

            grdMembers.Visible = true;
            grpMember.Visible = false;
        }
    }
}
