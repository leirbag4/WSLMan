using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Utils
{
    public class VersionHelper
    {
        public static string GetVersion()
        {
            string version = Application.ProductVersion;
            int index = version.IndexOf("+");

            if (index != -1)
                version = version.Substring(0, index);
            
            return version;
        }
    }
}
