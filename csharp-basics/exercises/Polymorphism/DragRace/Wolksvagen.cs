using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Wolksvagen  : ICar
    {
        private int currentSpeed = 0;

        public Wolksvagen()
        {

        }

        public void SpeedUp()
        {
            currentSpeed+=10;
        }

        public void SlowDown()
        {
            currentSpeed-=5;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
