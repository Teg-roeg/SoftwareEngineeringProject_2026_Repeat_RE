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
    }
}
