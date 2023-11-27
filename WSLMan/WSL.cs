using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands;
using WSLMan.Commands.Result;
using WSLMan.Distro;
using WSLMan.OS;
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

        public void StartDistro(DistroInfo distro, string user = "")
        {
            StartCmd cmd = new StartCmd();
            cmd.StartDistro(distro, user);
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

        public async Task<List<DistroOnline>> ListOnlineDistrosAsync()
        { 
            ListOnlineCmd cmd = new ListOnlineCmd();
            var result = await cmd.ListOnlineAsync();
            CheckCmd(cmd);

            return result;
        }

        public List<DistroPackage> GetCustomDistroPackages()
        {
            var packages = new List<DistroPackage>();
            string path = SaveData.CustomPackageDirPath;

            if (path.Trim() == "")
            {
                // do nothing
            }
            else if (!Directory.Exists(path))
            {
                // do nothing
            }
            else
            {
                string[] distroFiles = Directory.GetFiles(path);

                foreach (var fullFilename in distroFiles)
                {
                    packages.Add(new DistroPackage(Path.GetFileName(fullFilename), fullFilename));
                }
            }

            return packages;
        }

        /*public void ImportDistro(string customName, string destinationFolder, string inputFilename)
        {
            ImportCmd cmd = new ImportCmd();
            cmd.Import(customName, destinationFolder, inputFilename);
            CheckCmd(cmd);
        }*/

        public async Task<ImportCmdResult> Import(string customName, string destinationFolder, string fileName)
        {
            ImportCmd cmd = new ImportCmd();
            var result = await cmd.Import(customName, destinationFolder, fileName);
            CheckCmd(cmd);

            return result;
        }

        public async Task<ExportCmdResult> Export(string distroName, string fileName)
        {
            ExportCmd cmd = new ExportCmd();
            var result = await cmd.Export(distroName, fileName);
            CheckCmd(cmd);

            return result;
        }

        public async Task<UnregisterCmdResult> Unregister(string distroName)
        {
            UnregisterCmd cmd = new UnregisterCmd();
            var result = await cmd.Unregister(distroName);
            CheckCmd(cmd);

            return result;
        }

        public async Task<SetDefaultCmdResult> SetDefault(string distroName)
        {
            SetDefaultCmd cmd = new SetDefaultCmd();
            var result = await cmd.SetDefault(distroName);
            CheckCmd(cmd);

            return result;
        }

        public async Task<UserManagerResult> CreateUser(string distro, string username, OsId osType = OsId.OtherLinux)
        { 
            UserManagerCmd cmd = new UserManagerCmd();
            var result = await cmd.CreateUser(distro, username, osType);
            CheckCmd(cmd);

            return result;
        }

        public async Task<UserManagerResult> SetUserPassword(string distro, string username, string password, OsId osType = OsId.OtherLinux)
        {
            UserManagerCmd cmd = new UserManagerCmd();
            var result = await cmd.SetUserPassword(distro, username, password, osType);
            CheckCmd(cmd);

            return result;
        }

        public async Task<UserManagerResult> AddUserToGroups(string distro, string username, string[] groups, OsId osType = OsId.OtherLinux)
        {
            UserManagerCmd cmd = new UserManagerCmd();
            var result = await cmd.AddUserToGroups(distro, username, groups, osType);
            CheckCmd(cmd);

            return result;
        }

        public async Task<UserManagerResult> WriteTextFile(string distro, string text, string fileName, OsId osType = OsId.OtherLinux)
        {
            FileManagerCmd cmd = new FileManagerCmd();
            var result = await cmd.WriteTextFile(distro, text, fileName, osType);
            CheckCmd(cmd);

            return result;
        }


        public async Task<ShutdownCmdResult> Shutdown()
        {
            ShutdownCmd cmd = new ShutdownCmd();
            var result = await cmd.Shutdown();
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
