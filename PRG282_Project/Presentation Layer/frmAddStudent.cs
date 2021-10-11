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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddStudentModules addModule = new frmAddStudentModules();
            addModule.Show();
        }

        private void pbBackToGUI_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGUI backToGUIForm = new frmGUI();
            backToGUIForm.Show();
        }
    }
}
