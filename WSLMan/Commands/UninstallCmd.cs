using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class UninstallCmd : BaseCmd
    {

        public async Task<UninstallCmdResult> UninstallPackageName(string packageName)
        {
            return await CreateCommandProg<UninstallCmdResult>("powershell.exe", "Get-AppxPackage " + packageName + " | Remove-AppxPackage");
        }

        protected override void OnDataReceived(string data)
        {
            Println("data: " + data);
        }

        protected override void OnErrorDataReceived(string data)
        {
            Println("");
        }


    }
}
