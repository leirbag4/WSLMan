using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan
{
    public class ErrorInfo
    {
        public string Message { get; private set; } = "";

        public static ErrorInfo Create(string message)
        { 
            ErrorInfo error = new ErrorInfo() { Message = message };
            return error;
        }

        public override string ToString()
        {
            return "Error -> msg: " + Message;
        }
    }
}
