using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_basictypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
          

            byte myByte = 255; //range:0 - 255
            float myFloat = 3.14f;
            double myDouble = 2.54;
            decimal myDecimal = 3.14159M;
     
            string myName = "jay";

            Console.WriteLine(myName);
            //Declaration
            //<type><variableName> = <optional initializer>;
            int age;
            string country;
            //Initialization
            age = 41;
            Console.WriteLine(age);
            age = 42;
            Console.WriteLine(age);
            Console.ReadLine();


        }
    }
}
