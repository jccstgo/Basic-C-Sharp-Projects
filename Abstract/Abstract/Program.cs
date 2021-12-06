using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() {firstName= "Sample", lastName="Student" };//Intantiate the object 
            employee.SayName();//Call the method SayName to print the name 
            Console.ReadLine();
        }
    }
}
