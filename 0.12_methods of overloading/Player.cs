using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_methods_of_overloading
{
    class Player
        //calling a method
    {
         public void Attack(int damage)
         {
            Console.WriteLine($"Attacked for {damage}!");
         }

         public void Attack(int damage, string weapon)
         {
            Console.WriteLine($"Attacked for {weapon} for {damage}!");
         }

         public void Attack(int damage. string weapon, int hitTimes)
         {
            Console.WriteLine($"Attacked for {weapon} {hitTimes} times for {totalDamage}!");


         }


        //using returns example
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
