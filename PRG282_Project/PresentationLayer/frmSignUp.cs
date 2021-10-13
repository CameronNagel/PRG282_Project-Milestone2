using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        Validation validationClass = new Validation();
        frmExceptions exceptions = new frmExceptions();
        Validation loginFields = new Validation();
        UserLoginCredentials loginCredentials = new UserLoginCredentials();
        loginAccountCreated frmAccountCreated = new loginAccountCreated();


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
            
            List<string> ExistingUsers = new List<string>();
            //bool found = false;

            try
            {
                if (loginFields.ValidateFields(loginCredentials.getUserName(tbSignupUsername.Text), loginCredentials.getUserPassword(tbSignupPassword.Text)) == false)
                {

                    loginFields.DoesUserExist(tbSignupUsername.Text,tbSignupPassword.Text);


                    //using (TextReader reader = File.OpenText("LoginCredentials.txt"))
                    //{
                    //    string txt;
                    //    //string ExistingUsername;
                    //    //string ExistingPassword;

                    //    while ((txt = reader.ReadLine()) != null)
                    //    {
                    //        string[] myArr = txt.Split(',');
                    //        //ExistingUsername = myArr[0];
                    //        //ExistingPassword = myArr[1];



                    //        if (myArr.Contains(tbSignupUsername.Text))
                    //        {
                    //            found = true;
                    //            break;
                    //        }
                            

                    //    }


                    //}

                    //if (found == true)
                    //{
                    //    exceptions.UserAlreadyExists("User Already Exists");
                    //    exceptions.Show();
                    //}
                    //else
                    //{
                    //    using (TextWriter tr = File.AppendText("LoginCredentials.txt"))
                    //    {

                    //        tr.WriteLine(tbSignupUsername.Text + "," + tbSignupPassword.Text);

                    //    }

                    //    frmAccountCreated.Show();
                    //}



                }
                else
                {
                    exceptions.setEmptyTextBox("Please fill in all fields");
                    exceptions.Show();
                }


            }
            catch (EmptyTextBoxException exception)
            {
                Console.WriteLine(exception.Message);
                exceptions.Show();
            }

        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
