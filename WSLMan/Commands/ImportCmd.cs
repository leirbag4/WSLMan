using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.Distro;

namespace WSLMan.Commands
{
    public class ImportCmd : BaseCmd
    {
        /*public void Import(string customName, string destinationFolder, string inputFilename)
        {
            string fullCommand = "--import " + customName + " " + destinationFolder + " " + inputFilename;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "wsl",
                Arguments = fullCommand,
                //RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = false,
                //RedirectStandardOutput = true,
                //RedirectStandardError = true
            };

            Println("wsl " + fullCommand);

            Process process = new Process { StartInfo = psi };
            process.Start();
        }*/

        public async Task<ImportCmdResult> Import(string customName, string destinationFolder, string fileName)
        {
            return await CreateCommand<ImportCmdResult>("--import",  _quotes(customName) + " " + _quotes(destinationFolder) + " " + _quotes(fileName));
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
