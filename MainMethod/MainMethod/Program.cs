using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {            
            Overloading methodsOverloading = new Overloading();//An instance of the Class "Overloading" 
            
            int number_1 = 5;
            int result_1 = methodsOverloading.Operation(number_1);//Call the method "Operation" and passes an integer
            Console.WriteLine("The result 5+2 is: " + result_1);//Print the result

            decimal number_2= 10m;
            int result_2 = methodsOverloading.Operation(number_2);//Call the method "Operation" and passes a decimal
            Console.WriteLine("The result 10*2 is: " + result_2);//Print the result

            string number_3 = "20";
            int result_3 = methodsOverloading.Operation(number_3);//Call the method "Operation" and passes a string
            Console.WriteLine("The result 20-2 is: " + result_3);//Print the result

            Console.ReadLine();
        }
    }
}
