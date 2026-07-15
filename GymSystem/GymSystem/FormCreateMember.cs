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
    }
}
