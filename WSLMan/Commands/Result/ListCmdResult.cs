using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Distro;

namespace WSLMan.Commands.Result
{
    public class ListCmdResult : BaseResult
    {
        public List<DistroInfo> distros;

        public bool DistroExists(string distroName)
        {
            return GetDistro(distroName) != null;
        }

        public DistroInfo GetDistro(DistroInfo distro)
        {
            return GetDistro(distro.Name);
        }
            
        public DistroInfo GetDistro(string distroName) 
        {
            foreach(var distro in distros) 
            {
                if (distro.Name == distroName)
                    return distro;
            }

            return null;
        }

    }
}
