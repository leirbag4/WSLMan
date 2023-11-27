using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.Distro;

namespace WSLMan.Commands
{
    public class BaseCmd
    {
        public bool Error { get; private set; }
        public ErrorInfo ErrorInfo { get; private set; } = null;
        
        protected CmdRun proc;
        protected BaseResult baseResult = null;

        protected async Task<T> CreateCommand<T>(string command, string param0 = "", string param1 = "") where T : BaseResult, new()
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            baseResult = new T();

            string arguments = command;

                 if(param0 != "") arguments += " " + param0;
            else if(param1 != "") arguments += " " + param1;

            XConsole.Println("wsl " + arguments);

            proc = new CmdRun(CmdType.WSL, "wsl", arguments);
            proc.DataReceived +=        _OnDataReceived;
            proc.ErrorDataReceived +=   _OnErrorDataReceived;
            //proc.Complete +=          OnComplete;
            //proc.Start();

            proc.Complete += () => _OnComplete(tcs);
            await Task.Run(() => proc.Start());

            return await tcs.Task;
        }

        private void _OnDataReceived(string data)
        {
            /*try
            {
                XConsole.Println(data);
            }
            catch (Exception e)
            {
                CallError("Can't parse 'wsl " + proc.Arguments + "'", e);
            }*/

            OnDataReceived(data);
        }

        protected virtual void OnDataReceived(string data)
        { }

        private void _OnErrorDataReceived(string data)
        {
            CallError("DataReceivedError -> " + data);
            OnErrorDataReceived(data);
        }

        protected virtual void OnErrorDataReceived(string data)
        { }

        private void _OnComplete<T>(TaskCompletionSource<T> tcs) where T : BaseResult
        {
            T result = (T)baseResult;
            OnComplete(result);
            tcs.SetResult(result);
        }

        protected virtual void OnComplete(BaseResult result)
        { }

        /*private void OnComplete(TaskCompletionSource<BaseResult> tcs)
        {
            tcs.SetResult(baseResult);
        }*/

        protected string _quotes(string str)
        {
            return '"' + str + '"';
        }

        protected void CallError(string str)
        {
            ErrorInfo = ErrorInfo.Create(str);
            Error =     true;
            PrintError(ErrorInfo);

            if(baseResult != null)
                baseResult.SetError(ErrorInfo);
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
