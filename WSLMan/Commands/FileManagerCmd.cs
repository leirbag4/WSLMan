using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.OS;

namespace WSLMan.Commands
{
    public class FileManagerCmd : BaseCmd
    {

        public async Task<UserManagerResult> WriteTextFile(string distro, string text, string fileName, OsId osType = OsId.OtherLinux)
        {
            string cmd;

            //wsl -d Alpine -u root sh -c "echo -e '[user]\ndefault = new_user' > /etc/wsl.conf"
            if((osType == OsId.Alpine) || (osType == OsId.AlpineOther))
                cmd = "-d " + distro + " -u root sh -c \"echo -e '" + text + "' > " + fileName + "\"";
            else
                cmd = "-d " + distro + " -u root bash -c \"echo -e '" + text + "' > " + fileName + "\"";
            
            return await CreateCommand<UserManagerResult>(cmd);
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
