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
        DataAccessLayer.DataHandler handler = new DataAccessLayer.DataHandler();

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {

            handler.AddStudent(int.Parse(tbStudentNumber.Text), tbStudentName.Text + " "  + tbStudentSurname.Text, dtpStudentDOB.Value, cbGender.SelectedItem.ToString(), tbPhoneNumber.Text, tbStreetAddress.Text);
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
