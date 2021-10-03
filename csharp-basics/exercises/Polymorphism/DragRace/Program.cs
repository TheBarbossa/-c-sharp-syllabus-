using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var L = new Lexus("RCF", 10);
            var W = new Wolksvagen("Golf-8", 10);
            var B = new Bmw("M3", 10);
            var A = new Audi("A5", 10);
            var F = new Ford("Focus", 10);
            var T = new Tesla("Model-3", 10);

            List<ICar> cars = new List<ICar>()
            { L, W, B, A, F, T };
            var biggest = 0;
            string modelsName = "";
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    L.UseNitrousOxideEngine();
                    B.UseNitrousOxideEngine();
                }
                foreach (var myCars in cars)
                {
                    Console.WriteLine(myCars._name);
                    Console.WriteLine(myCars.StartEngine());

                    myCars.SpeedUp();
                    myCars.SpeedUp();
                    myCars.SpeedUp();
                    myCars.SpeedUp();
                    Console.WriteLine(myCars.ShowCurrentSpeed());
                    myCars.SlowDown();
                    myCars.SlowDown();
                    Console.WriteLine($"{myCars.ShowCurrentSpeed()}\n");
                    if (i == 9)
                    {
                        if (Convert.ToInt32(myCars.ShowCurrentSpeed()) > biggest)
                        {
                            biggest = Convert.ToInt32(myCars.ShowCurrentSpeed());
                            modelsName = myCars._name;
                        }
                    }
                }
            }
            Console.WriteLine($"Model: {modelsName}, speed {biggest} km/h");
            Console.ReadKey();
        }
    }
}