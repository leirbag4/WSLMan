using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class ShutdownCmd : BaseCmd
    {
        public async Task<ShutdownCmdResult> Shutdown()
        {

            ShutdownCmdResult result = await CreateCommand<ShutdownCmdResult>("--shutdown");

            return result;
        }

        protected override void OnDataReceived(string data)
        {
            Println(data);
        }

        protected override void OnErrorDataReceived(string data)
        {

        }

    }
}
