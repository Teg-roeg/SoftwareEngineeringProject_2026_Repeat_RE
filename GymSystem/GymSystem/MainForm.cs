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
    }
}
