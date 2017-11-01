using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "paul";

            switch (friend)
            { 
 
                case "Jay":
                    Console.WriteLine("Hey Jay");
                    Console.ReadLine();
                    break;
                case "Paul":
                    Console.WriteLine("paul is pretty cool");
                    Console.ReadLine();
                    break;
                case "Kenn":
                    Console.WriteLine("Silent master Kenn...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("I don't know you.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}