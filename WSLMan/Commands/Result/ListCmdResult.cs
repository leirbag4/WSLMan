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
    }
}
