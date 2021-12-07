using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", Id=2 };//Intantiate the object 
            Employee employee2 = new Employee() { firstName = "Sample", lastName = "Student", Id=2 };//Intantiate the object 
            
            employee1.SayName();//Call the method SayName to print the name 
            employee2.SayName();//Call the method SayName to print the name 

           

            IQuittable quit = new Employee();//Object of type IQuittable (Polymorphism)
            quit.Quit("QUIT METHOD\n\n");//Call the method Quit

            bool isEqual = employee1 == employee2;//Overload the "==" operator (Returns true if the "Id" property are equals)

            //Check if the "Id" between employees are equals
            if (isEqual)
                Console.WriteLine("The employees are equals");
            else
                Console.WriteLine("The employees aren't equals");

            bool isntEqual = employee1 != employee2;//Overload the "!=" operator (Returns true if the "Id" property aren't equals)
            
            //Check if the "Id" property between employees aren't equals
            if (isntEqual)
                Console.WriteLine("The employees aren't equals");
            else
                Console.WriteLine("The employees are equals");

            Console.ReadLine();
        }
    }
}
