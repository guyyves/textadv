﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadv
{
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int coins = 0;
        public int health = 10;
        public int damage = 1;
        public int armorVal = 0;
        public int potions = 5;
        public int weaponVal = 1;

        public int mods = 0;
        
        public int GetHealth()
        {
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower,upper); 
        }
        public int GetPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }
    }
}
