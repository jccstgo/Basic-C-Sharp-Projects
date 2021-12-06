using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Employee : Person//Inherit from the Class Person
    {
        public override void SayName()//Override the SayName method from the abstract method in the Class Person
        {
            Console.WriteLine("The name is====>\n\n");
            Console.WriteLine("Name: " + firstName + " " + lastName);   //Print the name of the employee     
        }
    }
}
