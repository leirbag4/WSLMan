using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.Distro;
using WSLMan.Register;

namespace WSLMan.Commands
{
    public class ListOnlineCmd : BaseCmd
    {
        private List<DistroOnline> _distros;
        private bool _cmd_list_allowed = false;


        public async Task<ListOnlineCmdResult> ListOnlineAsync()
        {
            _distros =          new List<DistroOnline>();
            _cmd_list_allowed = false;

            return await CreateCommand<ListOnlineCmdResult>("--list --online");
        }


        protected override void OnDataReceived(string data)
        {
            string[] parts = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                    if ((parts.Length >= 3) && (parts[0].ToLower() == "name") && (parts[1].ToLower() == "friendly") && (parts[2].ToLower() == "name"))
                    {
                        _cmd_list_allowed = true;
                    }
                    else if (_cmd_list_allowed)
                    {
                        DistroOnline distro;

                        if (parts.Length >= 2)
                        {
                            distro = new DistroOnline(parts[0].Trim(), string.Join(" ", parts.Skip(1)).Trim());
                        }
                        else
                        {
                            distro = new DistroOnline(parts[0].Trim(), parts[1].Trim());
                        }

                        _distros.Add(distro);
                    }
            }
            catch (Exception e)
            {
                CallError("Can't parse 'wsl --list --online'", e);
            }
        }

        protected override void OnErrorDataReceived(string data)
        {

        }

        protected override void OnComplete(BaseResult result)
        {
            ListOnlineCmdResult listOnlineResult = (ListOnlineCmdResult)result;

            listOnlineResult.distros = _distros;
        }

    }
}
