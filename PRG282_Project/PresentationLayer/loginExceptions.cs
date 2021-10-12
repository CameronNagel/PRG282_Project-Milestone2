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
    public partial class frmExceptions : Form
    {
        public frmExceptions()
        {
            InitializeComponent();
        }

        //Exception handling
        public void setEmptyTextBox(string message)
        {
            lblFillAllFields.Text = message;
            lblFillAllFields.Visible = true;
        }

        public void InvalidUserNamePassWord(string message)
        {
            lblInvalidUsernamePassword.Text = message;
            lblFillAllFields.Visible = false;
            lblInvalidUsernamePassword.Visible = true;
        }

        private void btnExceptionOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmExceptions_Load(object sender, EventArgs e)
        {

        }


        public void UserAlreadyExists(string message)
        {
            lblUserAlreadyExists.Text = message;
            lblUserAlreadyExists.Visible = true;
        }

    }
}
