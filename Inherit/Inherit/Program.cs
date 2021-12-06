using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FistName = "Sample", LastName="Student", Id=3};//Instantiate and initialize an Employe object
            employee.SayName();//This call the superclass method SayName()
            Console.ReadLine();

        }
    }
}
