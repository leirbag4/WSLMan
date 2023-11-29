using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.UI
{
    public class SimulateProgress
    {
        public float progressStep = 0.025f;
        public int millisTick =     1000;
        public float progress =       0;
        public SimulateProgress(float progressStep = 0.025f, int millisTick = 1000) 
        { 
            this.progressStep = progressStep;
            this.millisTick =   millisTick;
            this.progress=     0;
        }

        public void Start()
        { 
            progress = 0;
        }

        public float NextStep()
        {
            progress += progressStep;
            return progress;
        }
    }
}
