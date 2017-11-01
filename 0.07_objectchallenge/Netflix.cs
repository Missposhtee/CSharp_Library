using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_objectchallenge
{
    class Netflix
    {
        //Bronze:defining the PROPERTIES my netflix Object will have
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }


        //silver:Giving METHODS
        public void GetSuggestion()
        {
            if (this.Rating > 3.5)
            {
                Console.WriteLine("This is a pretty good show.");
            }
            else
            {
                Console.WriteLine("Don't waste your time.");

            }

        }




    }

}






      
    

