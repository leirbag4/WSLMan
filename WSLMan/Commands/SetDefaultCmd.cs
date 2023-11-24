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

        public async Task<SetDefaultResult> SetDefault(string distroName)
        {

            SetDefaultResult result = await CreateCommand<SetDefaultResult>("--set-default", distroName);

            return result;
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
