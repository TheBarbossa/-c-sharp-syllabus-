using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Ford : ICar
    {
        private int currentSpeed = 0;

        public Ford()
        {

        }

        public void SpeedUp()
        {
            currentSpeed+=5;
        }

        public void SlowDown()
        {
            currentSpeed+=5;
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
