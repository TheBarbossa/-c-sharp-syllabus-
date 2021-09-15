using System;

namespace DragRace
{
    public class Lexus : ICar, IBoost
    {
        private int currentSpeed = 0;
        public string _name { get; protected set; }

        public Lexus(string model, int speed)
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
            currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 20;
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}