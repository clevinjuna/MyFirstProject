﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectUwU
{
    internal class Dice
    {
        public static int RollDice() { 
        Random rand = new Random();
        return rand.Next(1, 7);
        }
    }
}
