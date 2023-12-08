using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WSLMan.Register;
using WSLMan.Save;

namespace WSLMan.Distro
{
    public class DistroInfo : DistroBase
    {
        public DistroState State { get; private set; }
        public int Version { get; private set; }
        public bool Default { get; private set; }

        public string Path { get { return _regDistroInfo.BasePath; } }
        public int DefaultUid { get { return _regDistroInfo.DefaultUid; } }
        public string Hash { get { return _regDistroInfo.Hash; } }
        public string PackageFamily { get { return _regDistroInfo.PackageFamily; } }

        public bool InstalledFromPackageOrStore { get { return PackageFamily != ""; } }

        public string AppxPackageName { get { if (PackageFamily == "") return ""; else return PackageFamily.Substring(0, PackageFamily.IndexOf("_")); } }

        public DistroConfig Config { get { return _config; } }

        private string ConfigPath { get { return System.IO.Path.Combine(_regDistroInfo.BasePath, DistroConfig.Filename); } }
        
        // this information is collected from windows registry but if not exist it can be null
        private RegDistroInfo _regDistroInfo = null;
        private DistroConfig _config = null;


        public DistroInfo(string name, string state, string version, bool isDefault)
        {
            Name = name;

            int ver = -1;
            if (int.TryParse(version, out ver))
                Version = ver;
            else
                throw new Exception("Can't prase distro version");

            state = state.ToLower();

            if (state == "running")
                State = DistroState.RUNNING;
            else if (state == "stopped")
                State = DistroState.STOPPED;
            else
                throw new Exception("Can't get the distro state");

            Default = isDefault;
        }

        public void SetRegDistroInfo(RegDistroInfo regDistroInfo)
        {
            _regDistroInfo = regDistroInfo;
        }

        private void CheckRegDistro()
        {
            if (_regDistroInfo == null)
            {
                string errMsg = "Can't continue because 'RegDistroInfo' was not loaded before 'VMConfig' config file!";
                XConsole.Alert(errMsg);
                throw new Exception(errMsg);
            }
        }

        // It must be used always after 'SetRegDistroInfo()'
        public void LoadConfig()
        {
            CheckRegDistro();

            if (File.Exists(ConfigPath))
            {
                // LOAD - config
                string json =   File.ReadAllText(ConfigPath);
                _config =       JsonSerializer.Deserialize<DistroConfig>(json);
            }
            else
            {
                // CREATE NEW - config
                _config = new DistroConfig();
                _config.Reset();
                SaveConfig();
            }
        }

        // It must be used always after 'SetRegDistroInfo()'
        public void SaveConfig()
        {
            CheckRegDistro();

            XConsole.Alert("save: " + ConfigPath);

            // SAVE - config
            string json = JsonSerializer.Serialize(_config);
            File.WriteAllText(ConfigPath, json);
            _config.SetAsSaved();
        }

        public override string ToString()
        {
            string str = "Name: " + Name + ", State: " + State + ", Version: " + Version;
            if (Default) str += " (default)";

            return str;
        }
    }
}
