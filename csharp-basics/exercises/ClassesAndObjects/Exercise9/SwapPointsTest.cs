using System;
using System.Drawing;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            swapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            Console.ReadKey();
        }
        public static void swapPoints(Object obj, Object obj2)
        {
            int x = ((Point)obj).X;
            int y = ((Point)obj).Y;
            ((Point)obj).X = ((Point)obj2).X;
            ((Point)obj).Y = ((Point)obj2).Y;
            ((Point)obj2).X = x;
            ((Point)obj2).Y = y;
        }
    }
}
