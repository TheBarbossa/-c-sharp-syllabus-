﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    public class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("zzzzhmhmhmzzzzzz");
        }
    }
}
