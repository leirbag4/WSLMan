using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class SetDefaultCmd : BaseCmd
    {

        public async Task<SetDefaultCmdResult> SetDefault(string distroName)
        {

            SetDefaultCmdResult result = await CreateCommand<SetDefaultCmdResult>("--set-default", distroName);

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
