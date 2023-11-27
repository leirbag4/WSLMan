using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class UnregisterCmd : BaseCmd
    {
        public async Task<UnregisterCmdResult> Unregister(string distroName)
        {
            return await CreateCommand<UnregisterCmdResult>("--unregister", distroName);
        }

        protected override void OnDataReceived(string data)
        {
            XConsole.Println("data: " + data);
        }

        protected override void OnErrorDataReceived(string data)
        {

        }

    }
}
