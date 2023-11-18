using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands
{
    public class BaseCmd
    {
        public bool Error { get; private set; }
        public ErrorInfo ErrorInfo { get; private set; } = null;

        protected void CallError(string str)
        {
            XConsole.PrintError(str);
            ErrorInfo = ErrorInfo.Create(str);
            Error =     true;
        }

    }
}
