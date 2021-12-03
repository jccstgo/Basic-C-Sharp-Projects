using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //The user input a number to convert it in binary, octal and hexadecimal
                Console.WriteLine("Input some integer number to convert in binary, octal and hexadecimal (additionally, there are three methods that add, subtract and multiply 5 to the selected number):");
                int numberSelected = Convert.ToInt32(Console.ReadLine());


                //"calc" instance of the Class "Calculator"
                Calculator calc = new Calculator();


                //Call to the methods that converts decimal in binary,octal and hexadecimal
                long binary = calc.Binary(numberSelected);
                int octal = calc.Octal(numberSelected);
                string hexadecimal = calc.Hexadecimal(numberSelected);


                //Print the result of the operations returns of the methods 
                Console.WriteLine("\n\nThe number in binary is: " + binary);
                Console.WriteLine("\n\nThe number in octal is: " + octal);
                Console.WriteLine("\n\nThe number in hexadecimal is: " + hexadecimal);

                //Additional methods to meet the requirements for methods that receive integers and return integers =)
                Console.WriteLine("***********************************************");
                int add = calc.AddFive(numberSelected);
                Console.WriteLine("\n\nThe result to add 5 is: "+add);
                int subtract = calc.SubtractFive(numberSelected);
                Console.WriteLine("\n\nThe result to subtract 5 is: " + subtract);
                int multiply = calc.MultiplyFive(numberSelected);
                Console.WriteLine("\n\nThe result to multiplay 5 is: " + multiply);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurs: " + ex.Message);
            }
            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
