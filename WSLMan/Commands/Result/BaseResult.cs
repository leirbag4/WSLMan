using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands.Result
{
    public class BaseResult
    {
        public bool Error { get; private set; } = false;
        public ErrorInfo ErrorInfo { get; private set; } = null;

        public void SetError(ErrorInfo error)
        {
            this.Error =        true;
            this.ErrorInfo =    error;
        }

    }
}
