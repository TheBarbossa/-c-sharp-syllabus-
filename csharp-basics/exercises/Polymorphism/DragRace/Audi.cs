using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;

        public string _name { get; protected set; }

        public Audi(string model, int speed)
        {
            currentSpeed = speed;
            _name = model;
        }

        public void SpeedUp()
        {
            currentSpeed += 10;
        }

        public void SlowDown()
        {
            currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}