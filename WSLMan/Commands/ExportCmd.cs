using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class ExportCmd : BaseCmd
    {

        public async Task<ExportCmdResult> Export(string distroName, string fileName)
        {

            ExportCmdResult result = await CreateCommand<ExportCmdResult>("--export", _quotes(distroName) + " " + _quotes(fileName));

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
