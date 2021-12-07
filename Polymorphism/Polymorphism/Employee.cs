using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable//Inherit from the Class Person and the IQuittable interface (must be implemented the method Quit)
    {
        public void Quit(string message)//This method is mandatory due to the implementation of the interface IQuittable 
        {
            Console.WriteLine(message);//Print the message
        }

        public override void SayName()//Override the SayName method from the abstract method in the Class Person
        {
            Console.WriteLine("The name is====>\n\n");
            Console.WriteLine("Name: " + firstName + " " + lastName);   //Print the name of the employee     
        }

    }
}