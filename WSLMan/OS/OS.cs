using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.OS
{
    public class OS
    {
        public string Name { get; private set; }
        public OsId Id { get; private set; }

        public OS(string name, OsId id) 
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
