using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._011_OOP_Game
{
    class Enemy : Character

    {
        //initializing the properties of the enemy
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }

    }
}
