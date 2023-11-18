using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands;
using WSLMan.Commands.Results;
using WSLMan.Register;

namespace WSLMan
{
    // https://learn.microsoft.com/en-us/windows/wsl/basic-commands

    public class WSL
    {
        public List<DistroInfo> Distros;
        
        public ErrorInfo ErrorInfo { get; private set; } = null;
        public bool Error { get; private set; } = false;



        public WSL() 
        {
            Distros = new List<DistroInfo>();
        }

        public void StartDistro(DistroInfo distro)
        {
            StartCmd cmd = new StartCmd();
            cmd.StartDistro(distro);
            CheckCmd(cmd);
        }

        public string StopDistro(DistroInfo distro)
        {
            StopCmd cmd = new StopCmd();
            var result = cmd.StopDistro(distro);
            CheckCmd(cmd);

            return result;
        }

        /// <summary>
        /// Get the list of all the installed distros
        /// </summary>
        /// <param name="matchWithRegister">merge and match info with windows registry to find for example installed path of distros but at the cost of speed. Set to 'false' to refresh only state.</param>
        /// <returns></returns>
        public async Task<List<DistroInfo>> ListDistrosAsync(bool matchWithRegister = true)
        {
            ListCmd cmd = new ListCmd();
            var result = await cmd.ListDistrosAsync(matchWithRegister);
            Distros = result;
            CheckCmd(cmd);

            return result;
        }

        public async Task<List<OnlineDistro>> ListOnlineDistrosAsync()
        { 
            ListOnlineCmd cmd = new ListOnlineCmd();
            var result = await cmd.ListOnlineAsync();
            CheckCmd(cmd);

            return result;
        }

        private void CheckCmd(BaseCmd cmd)
        {
            if (cmd.Error)
            {
                ErrorInfo = cmd.ErrorInfo;
                Error =     true;
            }
        }

        private void CallError(string str)
        {
            XConsole.PrintError(str);
            ErrorInfo = ErrorInfo.Create(str);
            Error = true;
        }


        private void Print(string str)
        {
            XConsole.Print(str);
        }

        private void Println(string str)
        { 
            XConsole.Println(str);
        }
    }
}
