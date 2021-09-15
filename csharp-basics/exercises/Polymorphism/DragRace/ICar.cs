using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICar
    {
        string _name { get; }
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        string StartEngine();
    }
}