using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays6
{
    public class Array6Extensions
    {
        public static bool RightRange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<1||array[i]>100) return false;
            }
            return true;
        }

        public static bool FirstIsSecond(int [] array, int [] array2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array2[i]) return false;
            }
            return true;
        }

        public static void LastIndex(int[] array)
        {
            array[^1] = -7;
        }
    }
}
