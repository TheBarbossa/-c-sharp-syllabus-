using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics7
{
    public class Arithmetics7Extension
    {
        public static double FinalPosition(double gravity, double fallTime, double iniVelocity, double iniPosition)
        {
            return 0.5 * gravity * Math.Pow(fallTime, 2) + iniVelocity + iniPosition;
        }
    }
}
