using CommandLauncher;
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

            CmdRun cmd = new CmdRun("wsl", fullCommand);
            cmd.OpenAndLaunch();
        }


    }
}
