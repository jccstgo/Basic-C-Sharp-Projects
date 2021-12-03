using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersByName
{
    class Names
    {
        public void Operation(int number_1, int number_2) 
        {
            int addTwo = number_1 + 2;//Take the firs number and add 2
            
            //Print the result of the operation in the firs number and shows the second number
            Console.WriteLine("The first number + 2 is:" + addTwo + " and the second number is: "+number_2);
            Console.ReadLine();
        }
    }
}
