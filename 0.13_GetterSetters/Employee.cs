using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GetterSetters
{
    class Employee
    {
       //Backing Fields
       private int _id;

        //properties
        public int ID
        {
            get
            {
                return _id;

            }
            set
            {
                if (value < 0)
                    throw new Exception("The employee ID is invalid");
                _id = value;
            }
        }
        public string Name { get; set; }


    }
}
