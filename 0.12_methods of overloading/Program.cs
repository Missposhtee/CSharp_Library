using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_methods_of_overloading
{
    class Program
    {
        static void Main(string[] args)
            //create player class with an Attack()methods
            //that accepts 3 diffrent set of parameters
            //for example
            //Attack(100)-->           "Attacked for 100!.
            //Attack(100, "Weapon") -->  "Attacked with weapon for 100!.
            //Attack (100, "Weapon", #ofTimes)  -->Attacked with weapon for 100
        {
            Player me = new Player();
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(500, "katana", 90);

            //using returns
            int num1 = 3;
            int num2 = 5;

            int product = num1 * num2;    //equals 15
            int product2 = me.Multiply(num1, num2);  //equals 15
                

               
        }
    }
}
