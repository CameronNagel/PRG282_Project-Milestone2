using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BusinessLogicLayer
{
    class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException() { }

        public EmptyTextBoxException(string message) : base(message) { }
        public EmptyTextBoxException(string message, Exception inner) : base(message, inner) { }
    }
}
