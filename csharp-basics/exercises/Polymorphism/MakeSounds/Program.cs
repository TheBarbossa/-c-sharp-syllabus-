using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var F = new Firework();
            var P = new Parrot();
            var R = new Radio();
            List<ISound> sounds = new List<ISound>()
            {
                F,P,R,R,F,P,R,F,P
            };
            foreach (var _sound in sounds)
            {
                _sound.PlaySound();
            }
            Console.ReadKey();
        }
    }
}