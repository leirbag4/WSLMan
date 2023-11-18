﻿using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Results;
using WSLMan.Register;

namespace WSLMan.Commands
{
    public class ListOnlineCmd : BaseCmd
    {
        List<OnlineDistro> _distros;
        private bool _cmd_list_allowed = false;

        public async Task<List<OnlineDistro>> ListOnlineAsync()
        {
            TaskCompletionSource<List<OnlineDistro>> tcs = new TaskCompletionSource<List<OnlineDistro>>();

            _distros = new List<OnlineDistro>();

            _cmd_list_allowed = false;
            //_matchWithRegister = matchWithRegister;

            proc = new CmdRun(CmdType.WSL, "wsl", "--list --online");
            proc.DataReceived += OnListDataReceived;
            proc.ErrorDataReceived += OnListDataErrorReceived;
            //proc.Complete +=          OnComplete;
            //proc.Start();

            proc.Complete += () => OnComplete(tcs);

            await Task.Run(() => proc.Start());

            return await tcs.Task;

        }

        private void OnListDataReceived(string data)
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
                        OnlineDistro distro;

                        if (parts.Length >= 2)
                        {
                            distro = new OnlineDistro(parts[0].Trim(), string.Join(" ", parts.Skip(1)).Trim());
                        }
                        else
                        {
                            distro = new OnlineDistro(parts[0].Trim(), parts[1].Trim());
                        }

                        _distros.Add(distro);
                    }
            }
            catch (Exception e)
            {
                CallError("Can't parse 'wsl --list --online'", e);
            }
        }

        private void OnListDataErrorReceived(string data)
        {
            CallError("DataReceivedError -> " + data);
        }

        private void OnComplete(TaskCompletionSource<List<OnlineDistro>> tcs)
        {
            tcs.SetResult(_distros);
        }
    }
}
