using System;

namespace DragRace
{
    public class Bmw : ICar, IBoost
    {
        private int currentSpeed = 0;

        public string _name { get; protected set; }

        public Bmw(string model, int speed)
        {
            currentSpeed = speed;
            _name = model;
        }

        public void SpeedUp()
        {
            currentSpeed += 15;
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 30;
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}