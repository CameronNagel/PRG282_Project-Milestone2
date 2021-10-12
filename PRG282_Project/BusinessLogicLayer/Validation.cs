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






        public void UserExists(string tbUsername, string tbPassword)
        {
            loginAccountCreated frmAccountCreated = new loginAccountCreated();

            bool found = false;

            using (TextReader reader = File.OpenText("LoginCredentials.txt"))
            {
                string txt;
                string username;
                

                while ((txt = reader.ReadLine()) != null)
                {
                    string[] myArr = txt.Split(',');
                    username = myArr[0];
                    

                    if (username != tbUsername)
                    {
                        found = false;

                        using (TextWriter tr = File.AppendText("LoginCredentials.txt"))
                        {
                           
                            tr.WriteLineAsync(tbUsername + ',' + tbPassword);

                        }

                        frmAccountCreated.Show();

                    }
                    else
                    {
                        found = true;
                    }

                }

                if (found == true)
                {
                    exceptions.InvalidUserNamePassWord("Invalid username or password!");
                    exceptions.Show();
                }

            }

        }

    }
}
