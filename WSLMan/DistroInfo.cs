using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan
{
    public class DistroInfo
    {
        public string Name { get; private set; }
        public DistroState State { get; private set; }
        public int Version { get; private set; }
        public bool Default { get; private set; }

        public DistroInfo(string name, string state, string version, bool isDefault)
        {
            Name =      name;

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

        public override string ToString()
        {
            string str = "Name: " + Name + ", State: " + State + ", Version: " + Version;
            if (Default) str += " (default)";

            return str;
        }
    }
}
