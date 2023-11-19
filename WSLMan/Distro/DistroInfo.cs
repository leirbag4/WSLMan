using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Register;

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


        // this information is collected from windows registry but if not exist it can be null
        private RegDistroInfo _regDistroInfo = null;

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

        public override string ToString()
        {
            string str = "Name: " + Name + ", State: " + State + ", Version: " + Version;
            if (Default) str += " (default)";

            return str;
        }
    }
}
