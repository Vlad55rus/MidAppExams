using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WrongArgumentException : System.Exception
    {
        public WrongArgumentException(string message) : base(message)
        {
        }
    }
}
