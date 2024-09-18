﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ComputerPlayer : IPlayer
    {

        private Random _rng = new Random(); 
        public Choice GetChoice()
        {
            Choice p2 = (Choice)_rng.Next(0, 3);
            return p2;
        }
    }
}
