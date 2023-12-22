using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Props;
using WSLMan.Commands.Result;

namespace WSLMan.Commands
{
    public class VersionCmd : BaseCmd
    {

        private VersionInfoProp _version = new VersionInfoProp();

        public async Task<VersionCmdResult> GetVersion()
        {
            return await CreateCommand<VersionCmdResult>("--version");
        }

        protected override void OnDataReceived(string data)
        {
            if (Error)
                return;

            Println(data);

            string[] arr = data.Split(':');
            string prop, value;

            if ((arr == null) || (arr.Length != 2))
            {
                CallError("Can't parse command --version");
                return;
            }

            prop =  arr[0].ToLower().Trim();
            value = arr[1].Trim();

            try
            { 
                string res = prop switch
                {
                    "wsl version" =>        _version.WSLVersion =        value,
                    "kernel version" =>     _version.KernelVersion =     value,
                    "wslg version" =>       _version.WSLgVersion =       value,
                    "msrdc version" =>      _version.MSRDCVersion =      value,
                    "direct3d version" =>   _version.Direct3DVersion =   value,
                    "dxcore version" =>     _version.DXCoreVersion =     value,
                    "windows version" =>    _version.WindowsVersion =    value
                };
            }
            catch(Exception e)
            {
                CallError("Can't prase --version command or WSL is an old version", e);
            }
        }

        protected override void OnErrorDataReceived(string data)
        {

        }

        protected override void OnComplete(BaseResult result)
        {
            VersionCmdResult versionCmdResult = (VersionCmdResult)result;

            versionCmdResult.VersionInfo = _version;
            
            base.OnComplete(result);
        }
    }
}
