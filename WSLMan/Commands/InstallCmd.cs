using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WSLMan.Commands
{
    public class InstallCmd : BaseCmd
    {
        public void InstallOnline(string distroName)
        {
            CmdRun cmd = new CmdRun("wsl", "--install --distribution " + distroName);
            cmd.OpenAndLaunch();
        }
    }
}
