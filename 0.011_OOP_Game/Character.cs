using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._011_OOP_Game
{
    public abstract class Character
    {
        //constants
        const int MIN_HEALTH = 0;

        //Properties

        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Energy { get; set; }
        public double CritChance { get; set; }

        //Methods
        public double Attack()

        {
            Random rnd = new Random();
            //setting up variable inside a method
            int spread = rnd.Next(-5, 6);
            int damage = this.AttackPower + spread;
            bool isCrit = IsCritical();
            //returning the for isCrit due to the expression for IsCritical which returns true 
            return isCrit ? damage * 2 : damage;
        }

        public bool IsCritical()
        {
            Random rnd = new Random();
            bool isCrit = rnd.Next(0, 101) < (this.CritChance * 100) ? true : false;
            return isCrit;
        }
            






    }
}
