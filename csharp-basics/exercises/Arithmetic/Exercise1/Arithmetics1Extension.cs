using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics1
{
    public class Arithmetics1Extension
    {
        public static bool IsNumber15(int num)
        {
            return (num == 15) ? true : false;
        }

        public static bool IsNumberSum15(int num1, int num2)
        {
            return (num1 + num2 == 15) ?  true :  false;
        }

        public static bool IsNumberDiff15(int num1, int num2)
        {
            return (num1 - num2 == 15) ? true : false;
        }

        public static bool TaskCheck(int num1, int num2)
        {
            return ((IsNumber15(num1) || IsNumber15(num2) || IsNumberSum15(num1, num2) || IsNumberDiff15(num1, num2) || IsNumberDiff15(num2, num1)) ? true : false);
        }
    }
}
