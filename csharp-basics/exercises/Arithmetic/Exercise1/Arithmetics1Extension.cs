using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics1
{
    public class Arithmetics1Extension
    {
        public static bool NumberIs15(int num)
        {
            return (num == 15) ? true : false;
        }

        public static bool NumberSum15(int num1, int num2)
        {
            return (num1 + num2 == 15) ?  true :  false;
        }

        public static bool NumberDiff15(int num1, int num2)
        {
            return (num1 - num2 == 15) ? true : false;
        }

        public static bool TaskCheck(int num1, int num2)
        {
            return ((NumberIs15(num1) || NumberIs15(num2) || NumberSum15(num1, num2) || NumberDiff15(num1, num2) || NumberDiff15(num2, num1)) ? true : false);
        }
    }
}
