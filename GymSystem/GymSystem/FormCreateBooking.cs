using System;
using System.Data;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FormCreateBooking : Form
    {
        MainForm parent;

        public FormCreateBooking()
        {
            InitializeComponent();
        }

        public FormCreateBooking(MainForm Parent)
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