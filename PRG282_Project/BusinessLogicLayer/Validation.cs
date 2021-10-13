using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project.BusinessLogicLayer
{
    class Validation
    {

        frmExceptions exceptions = new frmExceptions();
        loginAccountCreated frmAccountCreated = new loginAccountCreated();


        //Check textboxes for username and password and validate if it is empty or not
        public Boolean ValidateFields(string username, string password)
        {
            if (username == string.Empty || password == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<string> ReadTextFile()
        {

            string[] myArr = new string[] { };

            using (TextReader reader = File.OpenText("LoginCredentials.txt"))
            {
                string txt;

                while ((txt = reader.ReadLine()) != null)
                {
                    myArr = txt.Split(',');
                }
            }

            return myArr.ToList();

        }




        public void CheckLoginDetails(string tbUsername,string tbPassword)
        {

            bool found = false;

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

                    if (username == tbUsername && password == tbPassword)
                    {

                        found = true;

                        frmLogin obj = (frmLogin)Application.OpenForms["frmLogin"];
                        obj.Hide();

                        frmGUI studentInfoSystem = new frmGUI();
                        studentInfoSystem.userLoggedIn(username); 
                        
                        studentInfoSystem.Show();


                        break;  


                    }
                    else
                    {
                        found = false;
                    }

                }

                if (found == false)
                {
                    exceptions.InvalidUserNamePassWord("Invalid username or password!");
                    exceptions.Show();
                }

            }
        }



        public void DoesUserExist(string tbUsername, string tbPassword)
        {
            bool found = false;

            using (TextReader reader = File.OpenText("LoginCredentials.txt"))
            {
                string txt;
              

                while ((txt = reader.ReadLine()) != null)
                {
                    string[] myArr = txt.Split(',');


                    if (myArr.Contains(tbUsername))
                    {
                        found = true;
                        break;
                    }

                }

            }

            if (found == true)
            {
                exceptions.InvalidUserNamePassWord("User Already Exists!");
                exceptions.Show();
                
            }
            else
            {

                File.AppendAllText("LoginCredentials.txt",tbUsername + "," + tbPassword);

                
                frmAccountCreated.Show();

            }

        }

    }

}

