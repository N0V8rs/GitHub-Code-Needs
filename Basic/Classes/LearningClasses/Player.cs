﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        public int health;
        public int shield;
        public int x; // position
        public int y; // position

        public void Heal(int hp)
        {
            health = 100;
        }
    }
}
