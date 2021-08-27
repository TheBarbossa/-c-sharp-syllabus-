using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface ICar
    {
        string _name { get; }
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
