using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Ford : ICar
    {
        private int currentSpeed = 0;

        public string _name { get; protected set; }

        public Ford(string model, int speed)
        {
            currentSpeed = speed;
            _name = model;
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
