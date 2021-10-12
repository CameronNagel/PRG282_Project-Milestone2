using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BusinessLogicLayer
{
    class Validation
    {
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
    }
}
