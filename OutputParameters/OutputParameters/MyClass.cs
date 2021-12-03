using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    public class MyClass
    {
        //This method have two parameter, the first is the input and the second is the output
        public void DivideByTwo(int number, out int outputNumber) 
        {
            outputNumber = number/2;
        }

        //This method multiply by two an integer
        public void MultiplyByTwo() 
        {
            int number = 3;
            int result = number * 2;
            Console.WriteLine("The result to multiply 3 by 2 is: " + result);//Print the result
        }


        //Overload the method with one parameter
        public void MultiplyByTwo(int number) 
        {
            int result = number * 2;
            Console.WriteLine("The result to multiply " + number + " by 2 is: " + result);//Print the result
        }
    }
}
