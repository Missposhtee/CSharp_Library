﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            

            // another
            for (int i = 0; i < 10; i = i + 2)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
