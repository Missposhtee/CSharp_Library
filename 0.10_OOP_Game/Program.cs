using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character myName = new Character();
            Player newHero = new Player();
            Enemy Jenn = new Enemy();
            
            Console.WriteLine("Hello, wanderer.. \n" + "What be thy name?");
            newHero.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n\nNice to meet you,{newHero.Name}.");
            Console.WriteLine("What's your specialization frield?\n + 
                "1: Horse Mange \n" +
                "2: Troll Cat \n" +
                "3: Knight Templatetor\n" +
                "4: Demorgog \n" +
                "5: Sire Cena\n");
           Player.Specialization = int.Parse (Console.ReadLine());

            

        }
    }
}
