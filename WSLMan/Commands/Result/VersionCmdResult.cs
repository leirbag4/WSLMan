using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Props;

namespace WSLMan.Commands.Result
{
    public class VersionCmdResult : BaseResult
    {
        public VersionInfoProp VersionInfo { get; set; }
    }
}
