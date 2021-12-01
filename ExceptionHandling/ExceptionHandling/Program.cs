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
            try
            {
                List<int> numbers = new List<int>() {100,200,300,400,500,900,800,700,600 };
                Console.WriteLine("Input a number to divide each number in the list: ");
                int numberSelected = Convert.ToInt32(Console.ReadLine());
                int result;
                foreach (int number in numbers) 
                {
                    result = number / numberSelected;
                    Console.WriteLine("The result is: "+ result);
                }

                /*Console.WriteLine("Pick a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prick a second number: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();*/
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
