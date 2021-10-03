using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;

        public string _name { get; protected set; }

        public Tesla(string model, int speed)
        {
            currentSpeed = speed;
            _name = model;
        }

        public void SpeedUp()
        {
            currentSpeed += 25;
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "-- silence ---";
        }
    }
}