using System;

namespace DragRace
{
    public class Lexus : ICar,IBoost
    {
        private int currentSpeed = 0;

        public Lexus()
        {

        }

        public void SpeedUp() 
        {
            currentSpeed+=25;
        }

        public void SlowDown() 
        {
            currentSpeed-=10;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=30;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}