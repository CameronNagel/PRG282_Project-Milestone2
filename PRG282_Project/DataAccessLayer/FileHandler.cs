using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project.DataAccessLayer
{
    class FileHandler
    {
        public void write(string filepath, string user)    
        {
            //this code is meant to see if the file mentioned exists, and if it does not then it will create the path
            FileStream newStream = new FileStream(filepath, FileMode.OpenOrCreate);
            StreamWriter newWriter = new StreamWriter(newStream);
            MessageBox.Show("User registered");
            newWriter.Write(user); 
            newWriter.Close();
            newStream.Close();
        }

        public Boolean read(string username ,string password, string filepath)
        {
            //the objectivie of this code is to test if the user actually exists and the password they entered is the correct one
            //and if the data does match it will return a true value.
            if (File.Exists(filepath))
            {
                using (StreamReader read = new StreamReader(filepath))
                {
                    //this code assumes that the username and password were saved in the format of "username,password
                    string line = read.ReadLine();
                    int pos = line.IndexOf(",");

                    if (pos > 0)
                    {
                        string stored_username = line.Substring(0, pos);
                        string stored_password = line.Substring(pos + 1);

                        if ((stored_username == username)&&(stored_password == password))
                        {
                            return true;
                        }

                    }

                }

            }
            return  false;
        }
    }
}
