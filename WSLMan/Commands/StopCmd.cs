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
    public class StopCmd : BaseCmd
    {
        public async Task<StopCmdResult> StopDistro(DistroInfo distro)
        {
            return await CreateCommand<StopCmdResult>("--terminate ", distro.Name);
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
