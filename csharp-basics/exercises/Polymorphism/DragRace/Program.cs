using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var L = new Lexus("RCF",10);
            var W = new Wolksvagen("Golf-8", 10);
            var B = new Bmw("M3", 10);
            var A = new Audi("A5", 10);
            var F = new Ford("Focus", 10);
            var T = new Tesla("Model-3", 10);

            List<ICar> cars = new List<ICar>()
            { L, W, B, A, F, T };
            var biggest = 0;
            string modelsName="";
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
                    myCars.StartEngine();
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