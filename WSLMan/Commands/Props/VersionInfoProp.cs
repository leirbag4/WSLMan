using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands.Props
{
    public class VersionInfoProp
    {
        public string WSLVersion { get; set; }
        public string KernelVersion { get; set; }
        public string WSLgVersion { get; set; }
        public string MSRDCVersion { get; set; }
        public string Direct3DVersion { get; set; }
        public string DXCoreVersion { get; set; }
        public string WindowsVersion { get; set; }

        public override string ToString()
        {
            return "WSLVersion: " + WSLVersion + "\n" +
                           "KernelVersion: " + KernelVersion + "\n" +
                           "WSLgVersion: " + WSLgVersion + "\n" +
                           "MSRDCVersion: " + MSRDCVersion + "\n" +
                           "Direct3DVersion: " + Direct3DVersion + "\n" +
                           "DXCoreVersion: " + DXCoreVersion + "\n" +
                           "WindowsVersion: " + WindowsVersion;
        }
    }
}
