using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.OS;

namespace WSLMan.Commands
{
    public class UserManagerCmd : BaseCmd
    {

        public async Task<UserManagerResult> CreateUser(string distro, string username, OsId osType = OsId.OtherLinux)
        {
            string cmd;

            if (osType == OsId.AlpineOther)
                cmd = "-d " + distro + " -u root adduser -s /bin/ash -D " + username;
            else if (osType == OsId.Alpine)
                cmd = "-d " + distro + " -u root useradd -s /bin/ash -m " + username;
            else
                cmd = "-d " + distro + " -u root useradd -s /bin/bash -m " + username;

            return await CreateCommand<UserManagerResult>(cmd);
        }

        public async Task<UserManagerResult> SetUserPassword(string distro, string username, string password, OsId osType = OsId.OtherLinux)
        {
            string cmd;

            //wsl -d Alpine -u root ash -c 'echo "NewUser:NewPass" | chpasswd'
            if ((osType == OsId.Alpine) || (osType == OsId.AlpineOther))
                cmd = "-d " + distro + " -u root ash -c 'echo \"" + username + ":" + password + "\" | chpasswd'";
            else
                cmd = "-d " + distro + " -u root usermod --password '$(echo " + password + " | openssl passwd -1 -stdin)' " + username;

            return await CreateCommand<UserManagerResult>(cmd);
        }

        public async Task<UserManagerResult> AddUserToGroups(string distro, string username, string[] groups, OsId osType = OsId.OtherLinux)
        {
            string cmd;

            //wsl -d Alpine -u root adduser NewUser wheel            
            if(osType == OsId.AlpineOther)
                cmd = "-d " + distro + " -u root adduser " + username + " " + string.Join(", ", groups);
            else      
                cmd = "-d " + distro + " -u root usermod -aG " + string.Join(", ", groups) + " " + username;

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
