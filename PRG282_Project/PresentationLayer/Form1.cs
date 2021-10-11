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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Enabled = true;
            progressBarSplashScreen.Increment(2);
            if (progressBarSplashScreen.Value == 100)
            {
                timerSplashScreen.Enabled = false;
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
