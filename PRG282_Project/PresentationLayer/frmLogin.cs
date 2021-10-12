using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class frmLogin : Form
    {
        //Exceptions
        frmExceptions exceptions = new frmExceptions();
        
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
            //Validate
            UserLoginCredentials loginCredentials = new UserLoginCredentials();
            Validation loginFields = new Validation();
            try
            {
                if (loginFields.ValidateFields(loginCredentials.getUserName(tbUsername.Text), loginCredentials.getUserPassword(tbPassword.Text)) == false)
                {
                    using (TextReader reader = File.OpenText("LoginCredentials.txt"))
                    {
                        string txt;
                        string username;
                        string password;

                        while ((txt = reader.ReadLine()) != null)
                        {
                            string[] myArr = txt.Split(',');
                            username = myArr[0];
                            password = myArr[1];

                            if (username == tbUsername.Text && password == tbPassword.Text)
                            {
                                frmGUI studentInfoSystem = new frmGUI();
                                studentInfoSystem.userLoggedIn(username);
                                this.Hide();
                                studentInfoSystem.Show();
                                break;
                            }
                            else
                            {
                                exceptions.InvalidUserNamePassWord("Invalid username or password!");
                                exceptions.Show();
                            }
                        }
                    }
                }
                else
                {
                    throw new EmptyTextBoxException("Please fill in all fields!");
                }
            }
            catch (EmptyTextBoxException ex)
            {

                exceptions.setEmptyTextBox(ex.Message);
                exceptions.Show();
            }
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
