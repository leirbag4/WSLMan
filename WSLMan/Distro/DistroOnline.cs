using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Distro
{
    public class DistroOnline : DistroBase
    {
        public string FriendlyName { get; private set; }

        public DistroOnline(string name, string friendlyName)
        {
            Name = name;
            FriendlyName = friendlyName;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", FriendlyName: " + FriendlyName;
        }
    }
}
