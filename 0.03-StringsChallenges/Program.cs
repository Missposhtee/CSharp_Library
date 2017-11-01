using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            //Currency
            double Cash = 563.3265;
            Console.WriteLine("{0:C}", Cash);
        
            //percentage
            double exchangeRate = 23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            
         //Phone Number
         int PhoneNumber = 1234567890;
            Console.WriteLine("{0:(###) ### - ####}", PhoneNumber);
            Console.ReadLine();

        }
    }
}
