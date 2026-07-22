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
    }
}
