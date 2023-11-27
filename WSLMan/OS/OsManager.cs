using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.OS
{
    public class OsManager
    {

        public static List<OS> operativeSystems { get; private set; }

        public static void Initialize()
        {
            operativeSystems = new List<OS>();

            InsertOS("Other Linux",     OsId.OtherLinux);
            InsertOS("Debian",          OsId.Debian);
            InsertOS("Ubuntu",          OsId.Ubuntu);
            InsertOS("Alpine",          OsId.Alpine);
            InsertOS("Alpine (other)",  OsId.AlpineOther);
        }

        private static void InsertOS(string name, OsId id)
        {
            operativeSystems.Add(new OS(name, id));
        }
    }
}
