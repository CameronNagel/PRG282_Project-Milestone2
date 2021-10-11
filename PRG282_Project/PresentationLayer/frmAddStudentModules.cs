using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmAddStudentModules : Form
    {
        public frmAddStudentModules()
        {
            InitializeComponent();
        }

        private void pbBackToGUI_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGUI backToGUI = new frmGUI();
            backToGUI.Show();
        }
    }
}
