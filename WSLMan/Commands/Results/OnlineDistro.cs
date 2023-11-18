using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands.Results
{
    public class OnlineDistro
    {
        public string Name { get; private set; }
        public string FriendlyName { get; private set; }

        public OnlineDistro(string name, string friendlyName)
        {
            Name = name;
            FriendlyName = friendlyName;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", FriendlyName: " + FriendlyName;
        }
    }
}
