using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try/catch block that ensures that the input is ok
            try
            {
                //List the numbers
                List<int> numbers = new List<int>() {100,200,300,400,500,900,800,700,600 };
                //The user input an int number to divide the numbers in the list
                Console.WriteLine("Input a number to divide each number in the list: ");
                int numberSelected = Convert.ToInt32(Console.ReadLine());
                int result;
                //This foreach take each element in the list and divide by the number selected
                foreach (int number in numbers) 
                {
                    result = number / numberSelected;
                    Console.WriteLine("The result is: "+ result);
                }
            }
            //This catch block shows if ocurre a problem in the try block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //This prints the last line that indicates the end of the try/catch block
            Console.WriteLine("\nThe program has emerged from the try\\catch block");
            Console.ReadLine();

        }
    }
}
