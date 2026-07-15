using System;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuCreateMember(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateMember nextForm = new FormCreateMember(this);
            nextForm.Show();
        }
    }
}
