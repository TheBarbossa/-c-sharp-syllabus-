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
            return ((num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15) ? true : false);
        }
    }
}
