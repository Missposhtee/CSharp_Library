using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_arrayprojects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = new string[3];
            food[0] = "Pizza";
            food[1] = "French Toast";
            food[2] = "salads";
            foreach (string x in food)
                Console.WriteLine(x);
            Console.ReadLine();

            //silver
            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };
            int[] numbers3 = new int[5];
            //using loop to create an array
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];

            }

            //using a foreach loop to display the array
            foreach(int number in numbers3)
            {
                Console.WriteLine(number);
            }



            //GOLD
            int[] randomNumbers = new int[10];

            Random rnd = new Random();

            for(int i = 0; i < randomNumbers.Lenght; i++)
            {
                randomNumbers[i] = rnd.Next(100);

            }
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
                Console.ReadLine();

            }


            
            
         


        }
    }
}
