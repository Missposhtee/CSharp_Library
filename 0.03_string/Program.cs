using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string Occupation;

            FirstName = "Fred";
            LastName = "Rogers";
            Occupation = "Tv personality";

            string FullName = FirstName + "" + LastName;
            Console.WriteLine(FullName);


            //string Interpolation
            Console.WriteLine("Hello, my name is  "+ FullName + " .I am a "+ Occupation +". ");

                //string Interpolation
                Console.WriteLine("Hello, my name is{0}.I am a{1}", FullName, Occupation);
            //String Interpolation
            Console.WriteLine($"Hello my name is{FullName}. I am a {Occupation}. ");
            Console.ReadLine();                             
            
        }
    }
}
