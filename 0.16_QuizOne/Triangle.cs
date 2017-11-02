using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        //Constructors
        public Triangle(int tbase, int theight)
        {
            this.TBase = tbase;
            this.THeight = theight;
        }


        //properties
        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }

        //Methods
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2.0;
            return this.TArea;
        }
    }
}
