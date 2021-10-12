using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.PresentationLayer
{
    public partial class loginAccountCreated : Form
    {
        public loginAccountCreated()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmSignUp frmSignUpScreen = new frmSignUp();
            frmSignUpScreen.Hide();

            frmLogin frmLoginScreen = new frmLogin();
            frmLoginScreen.Show();

            this.Hide();

        }
    }
}
