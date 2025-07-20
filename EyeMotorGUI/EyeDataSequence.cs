using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeMotorGUI
{
    class EyeDataSequence
    {
        public EyeDataSequence(float time, float LE, float RE, float LP, float RP)
        {
            this.time = time;
            this.LE = LE;
            this.RE = RE;
            this.LP = LP;
            this.RP = RP;
        }

        public float time, LE, RE, LP, RP;
    };

}
