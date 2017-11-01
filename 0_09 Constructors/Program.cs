using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Students jayStudent = new Students("Jay","Jackson",5,1);
            Students jenstudent = new Students("jen");
           

            //without construstors its still same code

           // jayStudents.FirstName = "Jay";
            //jayStudents.LastName = "Jackson";
            //jayStudents.Grade = 1;
            //jayStudents.Age = 5;


        } 
    }
}
