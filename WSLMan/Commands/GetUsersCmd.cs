using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Props;
using WSLMan.Commands.Result;
using WSLMan.OS;

namespace WSLMan.Commands
{
    public class GetUsersCmd : BaseCmd
    {
        private List<UserInfoProp> users;
        public async Task<GetUsersCmdResult> GetUsers(string distro, OsId osType = OsId.OtherLinux)
        {
            users = new List<UserInfoProp>();

            string cmd;

            if (osType == OsId.AlpineOther)
                cmd = "-d " + distro + " -u root cat /etc/passwd";
            else if (osType == OsId.Alpine)
                cmd = "-d " + distro + " -u root cat /etc/passwd";
            else
                cmd = "-d " + distro + " -u root cat /etc/passwd";

            return await CreateCommand<GetUsersCmdResult>(CmdType.Windows, cmd);
        }

        protected override void OnDataReceived(string data)
        {
            Println("data: " + data);

            string[] arr = data.Split(':');
            
            users.Add(new UserInfoProp(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]));
        }

        protected override void OnErrorDataReceived(string data)
        {

        }

        protected override void OnComplete(BaseResult result)
        {
            GetUsersCmdResult getUsersResult = (GetUsersCmdResult)result;

            getUsersResult.Users = users.ToArray();

            base.OnComplete(result);
        }
    }
}
