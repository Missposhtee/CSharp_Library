using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triOne = new Triangle(3, 2);
            Triangle triTwo = new Triangle(12, 1);
            Triangle triThree = new Triangle(2, 4);
            Triangle triFour = new Triangle(6, 5);
            Triangle triFive = new Triangle(8, 3);


            triOne.Area();
            triTwo.Area();
            triThree.Area();
            triFour.Area();
            triFive.Area();



        }

    }
}
