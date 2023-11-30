using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Props;

namespace WSLMan.Commands.Result
{
    public class GetUsersCmdResult : BaseResult
    {
        public UserInfoProp[] Users { get; set; }
    }
}
