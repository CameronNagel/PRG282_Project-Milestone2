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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
       
            
        }

        private void pbHidePassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            pbHidePassword.Visible = false;
            pbSeePassword.Visible = true;
        }

        private void pbSeePassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            pbHidePassword.Visible = true;
            pbSeePassword.Visible = false;
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            frmSignUp signupForm = new frmSignUp();
            this.Hide();
            signupForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmGUI studentInfoSystem = new frmGUI();
            this.Hide();
            studentInfoSystem.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
          
        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
