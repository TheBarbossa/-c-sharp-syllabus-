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
            SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            Console.ReadKey();
        }
        public static void SwapPoints(Point p1, Point p2)
        {
            int x = ((Point)p1).X;
            int y = ((Point)p1).Y;
            ((Point)p1).X = ((Point)p2).X;
            ((Point)p1).Y = ((Point)p2).Y;
            ((Point)p2).X = x;
            ((Point)p2).Y = y;
        }
    }
}
