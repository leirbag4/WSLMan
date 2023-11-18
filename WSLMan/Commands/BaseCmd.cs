using CommandLauncher;
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
        
        protected CmdRun proc;
        protected void CallError(string str)
        {
            ErrorInfo = ErrorInfo.Create(str);
            Error =     true;
            PrintError(ErrorInfo);
        }

        protected void CallError(string str, Exception e)
        {
            ErrorInfo = ErrorInfo.Create(str, e);
            Error = true;
            PrintError(ErrorInfo);
        }

        protected void Print(string str)
        {
            XConsole.Print(str);
        }

        protected void Println(string str)
        {
            XConsole.Println(str);
        }

        protected void PrintError(string str)
        {
            XConsole.PrintError(str);
        }

        protected void PrintError(ErrorInfo error)
        {
            XConsole.PrintError(error);
        }

        protected void Alert(string str)
        { 
            XConsole.Alert(str);
        }

    }
}
