using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Distro
{
    public class DistroPackage : DistroBase
    {
        public string Path { get; private set; }

        public DistroPackage(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Path: " + Path;
        }
    }
}
