using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_10IphoneChallenge
{
    class MobilePhone
    {

        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        //PROPERTIES
        public string Make { get; set; }
        public string Model { get; set; }

        //Methods
        public void PrintPhone()
        {
            Console.WriteLine("I own a {this.Make}{this.Model}");
            Console.ReadLine();
        }
    }
}
