using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
//Challenge
//Create a new "circle" class

//Circle should have a constructor
//That inherits from 'Shape'
//and implements the Shape.Area() method.
//
//Circle should have a constructor that accepts
//one parameter, being radius.
//
//Sidenote: Area of circle = Pi*r^2
//Sidenote: let Pi = 3.14 (or use Math.PI)
//
//Feeling frisky?
//Do the same thing, only this time
//using triangle

{
    class Circle : Shape
    {
        //Constructors
        public Circle (int radius)
        {
           this.Radius = radius;
        }

        //properties
        public int Radius { get; set; }

        //methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }
    }
}
