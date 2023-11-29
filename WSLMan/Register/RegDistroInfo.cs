using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Register
{
    public class RegDistroInfo
    {
        public string Hash { get; private set; }
        public string BasePath {get; private set;}
        public int DefaultUid {get; private set;}
        public string DistributionName {get; private set;}
        public int State {get; private set;}
        public int Version {get; private set;}
        public string PackageFamily { get; private set; }


        public RegDistroInfo(string hash, string basePath, string defaultUid, string distributionName, string state, string version, string packageFamily)
        {
            Hash =              hash;
            BasePath =          basePath;
            DefaultUid =        int.Parse(defaultUid);
            DistributionName =  distributionName;
            State =             int.Parse(state);
            Version =           int.Parse(version);
            PackageFamily =     packageFamily;

            if (BasePath.StartsWith(@"\\?\"))
                BasePath = BasePath.Substring(@"\\?\".Length);
        }

        public override string ToString()
        {
            return "Hash: " + Hash + ", BasePath: " + BasePath + ", DefaultUid: " + DefaultUid + " DistributionName: " + DistributionName + ", State: " + State + " Version: " + Version + " PackageFamily: " + PackageFamily;
        }
    }
}
