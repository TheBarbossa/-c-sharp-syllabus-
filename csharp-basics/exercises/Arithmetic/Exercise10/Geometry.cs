using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Parameter cannot be 0 or negative", nameof(radius));
            }
            else
            {
                return Math.PI * (double)radius * 2;
            }
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Parameter cannot be 0 or negative", nameof(length));
            }
            else if (width <= 0)
            {
                throw new ArgumentException("Parameter cannot be 0 or negative", nameof(width));
            }
            else
            {
                return (double)(length * width);
            }
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0)
            {
                throw new ArgumentException("Parameter cannot be 0 or negative", nameof(ground));
            }
            else if (h <= 0)
            {
                throw new ArgumentException("Parameter cannot be 0 or negative", nameof(h));
            }
            else
            {
                return (double) (ground * h) * 0.5;
            }
        }
    }
}