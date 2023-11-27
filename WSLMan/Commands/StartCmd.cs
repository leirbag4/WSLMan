using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Distro;

namespace WSLMan.Commands
{
    public class StartCmd : BaseCmd
    {

        public void StartDistro(DistroInfo distro, string username = "")
        {
            string fullCommand = "-d " + distro.Name;

            if (username != "")
                fullCommand += " --user " + username;

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

            Process process = new Process { StartInfo = psi };
            process.Start();
        }


    }
}
