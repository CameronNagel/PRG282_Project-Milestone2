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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void pbSignUpHidePassword_Click(object sender, EventArgs e)
        {
            tbSignupPassword.UseSystemPasswordChar = true;
            pbSignUpHidePassword.Visible = false;
            pbSignUpSeePassword.Visible = true;
        }

        private void pbSignUpSeePassword_Click(object sender, EventArgs e)
        {
            tbSignupPassword.UseSystemPasswordChar =false;
            pbSignUpHidePassword.Visible = true;
            pbSignUpSeePassword.Visible = false;
        }

        private void pbBackButtonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin backToLogin = new frmLogin();
            backToLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin newUserLogin = new frmLogin();
            newUserLogin.Show();
        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
