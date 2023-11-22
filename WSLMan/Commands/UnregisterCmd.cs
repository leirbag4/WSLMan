using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands
{
    public class UnregisterCmd : BaseCmd
    {
        public async Task<bool> Unregister(string distroName)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            string fullCommand = "--unregister " + distroName;

            XConsole.Println(fullCommand);

            proc = new CmdRun(CmdType.WSL, "wsl", fullCommand);
            proc.DataReceived +=        OnListDataReceived;
            proc.ErrorDataReceived +=   OnListDataErrorReceived;
            //proc.Complete +=          OnComplete;
            //proc.Start();

            proc.Complete += () => OnComplete(tcs);

            await Task.Run(() => proc.Start());

            return await tcs.Task;

        }

        private void OnListDataReceived(string data)
        {
            try
            {
                XConsole.Println(data);
            }
            catch (Exception e)
            {
                CallError("Can't parse 'wsl " + proc.Arguments + "'", e);
            }
        }

        private void OnListDataErrorReceived(string data)
        {
            CallError("DataReceivedError -> " + data);
        }

        private void OnComplete(TaskCompletionSource<bool> tcs)
        {
            tcs.SetResult(true);
        }
    }
}
