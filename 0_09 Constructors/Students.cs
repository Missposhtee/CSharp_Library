using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_09_Constructors
{
    class Students { 

    //constructor 0

        public Students(string firstName)
    {
        this.FirstName = firstName;

    }



    //Constructor 1
    public Students(string firstName, string lastName, int grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }



    // Constructors 2
    public Students(string firstName, string lastName, int age, int grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Grade = grade;
    }






    
     //Properties

    
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
}








    



   

















   


}
