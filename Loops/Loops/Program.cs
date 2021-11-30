using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            //Repeat while the number is < 10 repeat
            while (number<10) 
            {
                Console.WriteLine("While number is less than 10");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
            }
            //Enter the do while statement and repeat the loop until the number is >=20 
            do {
                Console.WriteLine("Do While the number is less than 20");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number<20);
            Console.WriteLine("You pass over while an do while statements");
            Console.ReadLine();
        }    
    }
}
